using Abstractions;
using UnityEngine;

namespace Core
{
    public class MainUnit : MonoBehaviour, ISelectable
    {
        public float CurrentHealth => _currentHealth;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public Transform CurrentTransform => _currentTransform;

        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;

        private float _currentHealth = 100;
        private Transform _currentTransform;
        public void Start()
        {
            _currentTransform = gameObject.transform.transform; //найти другой способ
        }
    }
}