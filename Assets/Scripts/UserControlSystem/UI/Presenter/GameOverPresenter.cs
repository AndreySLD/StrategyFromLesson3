using UnityEngine;
using Zenject;
using UniRx;
using Abstractions;

public class GameOverPresenter : MonoBehaviour
{
    [Inject] private IGameStatus _gameStatus;
    private void Init()
    {
        _gameStatus.Status.ObserveOnMainThread().Subscribe(result =>
        {
            if (result == 0)
            {
                Debug.Log("Tie.");
            }
            else
            {
                Debug.Log($"Player {result} is a winner.");
            }
        });
    }
}
