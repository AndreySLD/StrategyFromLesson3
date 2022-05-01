using System.Linq;
using Abstractions;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;
using UserControlSystem;

public sealed class MouseInteractionPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SelectableValue _selectedObject;
    [SerializeField] private EventSystem _eventSystem;
    
    [SerializeField] private Vector3Value _groundClicksRMB;
    [SerializeField] private AttackableValue _attackablesRMB;
    [SerializeField] private Transform _groundTransform;
    
    private Plane _groundPlane;
    
    private void Awake() => _groundPlane = new Plane(_groundTransform.up, 0);

    private void Start()
    {
        var LMBClick = Observable.EveryUpdate().Where(_ => Input.GetMouseButton(0) && !_eventSystem.IsPointerOverGameObject());
        var RMBClick = Observable.EveryUpdate().Where(_ => Input.GetMouseButton(1) && !_eventSystem.IsPointerOverGameObject());

        var LMBray = LMBClick.Select(_ => _camera.ScreenPointToRay(Input.mousePosition));
        var RMBray = RMBClick.Select(_ => _camera.ScreenPointToRay(Input.mousePosition));

        var LMBHits = LMBray.Select(ray => Physics.RaycastAll(ray));
        var RMBHits = RMBray.Select(ray => (ray, Physics.RaycastAll(ray)));

        LMBHits.Subscribe(hits =>
        {
            if (WeHit<ISelectable>(hits, out var selectable))
            {
                _selectedObject.SetValue(selectable);
            }
            else
            {
                _selectedObject.SetValue(null);
            }
        });

        RMBHits.Subscribe(data =>
        {

            if (WeHit<IAttackable>(data.Item2, out var attackable))
            {
                _attackablesRMB.SetValue(attackable);
            }
            else if (_groundPlane.Raycast(data.Item1, out var enter))
            {
                _groundClicksRMB.SetValue((data.Item1.origin + (data.Item1.direction * enter)));
            }
        });
    }

    private bool WeHit<T>(RaycastHit[] hits, out T result) where T : class
    {
        result = default;
        if (hits.Length == 0)
        {
            return false;
        }    
        result = hits
            .Select(hit => hit.collider.GetComponentInParent<T>())
            .FirstOrDefault(c => c != null);
        return result != default;
    }
}