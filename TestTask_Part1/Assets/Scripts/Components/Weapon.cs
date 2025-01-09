using Configs;
using Interfaces;
using UnityEngine;

namespace Components
{
    public abstract class Weapon : MonoBehaviour, IInitable
    { 
        private  SpawnComponent _spawnComponent; 
        private  WeaponConfig _config;
  
        public void DoAttack(Vector2 spawnPosition)
        {
            _spawnComponent.SpawnToPosition(_config.Prefab, spawnPosition, Quaternion.identity);
        }

        public void Inject(GameObjectConfig config)
        {
            _spawnComponent = new();
            _config = (WeaponConfig)config; 
        }
    }
}
