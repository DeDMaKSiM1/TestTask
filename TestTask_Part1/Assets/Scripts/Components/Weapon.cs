using Configs;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Components
{
    public class Weapon
    {
        //чисто спавн снаряда
        private SpawnComponent _spawnComponent; 
        private WeaponConfig _config;
        public Weapon(WeaponConfig config)
        {
            _spawnComponent = new();
            _config = config;
        }
        public void DoAttack(Vector2 position)
        {
            _spawnComponent.SpawnToPosition(_config.Prefab, position, Quaternion.identity);
        }
    }
}
