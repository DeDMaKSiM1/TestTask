using Configs;
using Managers;
using UnityEngine;
using Zenject;

namespace Components
{
    public class Weapon
    {
        private SpawnManager _spawnManager;
        private WeaponConfig _config;


        [Inject]
        private void Construct(WeaponConfig config, SpawnManager spawnManager)
        {
            _config = config;
            _spawnManager = spawnManager;
        }
        public void DoAttack(Vector2 spawnPosition)
        {
            //_spawnManager.SpawnToPosition(_config.Prefab);
        }
    }
}
