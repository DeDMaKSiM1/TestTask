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

        protected AttackComponent weapon;

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
            weapon = new AttackComponent();
        }

        public void GetConfigData(CharacterConfig config)
        {
            Speed = config.Speed;
        }
        public void Attack()
        {
            //МБ надо сделать ивентами?) хз
            weapon.DoAttack();
        }
    }
}

