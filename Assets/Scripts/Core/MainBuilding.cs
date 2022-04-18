using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
    {
        public float CurrentHealth => _currentHealth;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public Transform CurrentTransform => _currentTransform;

        [SerializeField] private Transform _unitsParent;

        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;

        private float _currentHealth = 1000;
        private Transform _currentTransform;

        private void Start()
        {
            _currentTransform = gameObject.transform.transform; //найти другой способ
        }
        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
            => Instantiate(command.UnitPrefab,
                new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
                Quaternion.identity,
                _unitsParent);
    }
}