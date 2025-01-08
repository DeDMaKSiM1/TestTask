using Components;
using Configs;
using UnityEngine;

namespace Characters
{
    public abstract class Character : MonoBehaviour
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
            _weapon = new Weapon(_config.WeaponConfig);
        }

        public void GetConfigData(CharacterConfig config)
        {
            _config = config;
            Speed = config.Speed;
        }
        public void Attack()
        { 
            _weapon.DoAttack(_projectileSpawnPosition.position);
        }
    }
}

