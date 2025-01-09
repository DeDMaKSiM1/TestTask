using Components;
using Configs;
using Interfaces;
using UnityEngine;

namespace Characters
{
    public abstract class Character : MonoBehaviour, IInitable
    {
        [SerializeField] protected Transform _projectileSpawnPosition;

        protected float _speed;
        protected Rigidbody2D _rb;

        protected Weapon _weapon;

        protected CharacterConfig _config;
        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 1)
                {
                    _speed = 1;
                    return;
                }
                _speed = value;
            }
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void Inject(GameObjectConfig config)
        {
            _config = (CharacterConfig)config;
            _weapon = _config.WeaponConfig.Weapon;
            Debug.Log(_config.WeaponConfig.Weapon);
            
            Speed = config.Speed;
        }
        public void Attack()
        {
            _weapon.DoAttack(_projectileSpawnPosition.position);
        }
 
    }
}

