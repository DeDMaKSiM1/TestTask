using Components;
using Configs;
using Interfaces;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Zenject;

namespace Characters
{
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected Transform _projectileSpawnPosition;
        protected float _speed;
        protected Rigidbody2D _rb;

        protected Weapon _weapon;


        protected SpawnComponent _spawnComponent;
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
            _weapon = new Weapon();
        }




    }
}

