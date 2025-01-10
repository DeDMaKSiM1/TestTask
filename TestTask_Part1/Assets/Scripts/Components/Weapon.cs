using Configs;
using Interfaces;
using Managers;
using UnityEngine;
using Zenject;

namespace Components
{
    public class Weapon : IDamageDealable
    {
        private SpawnComponent _spawnComponent;

        [Inject]
        private void Construct(SpawnComponent spawnComponent)
        {
            _spawnComponent = spawnComponent;
        }
        public void DoAttack(WeaponConfig config, Vector2 spawnPosition, float angle)
        {
            var projectile = _spawnComponent.SpawnToPosition(config.Prefab, spawnPosition).GetComponent<Projectile>();
            projectile.Launch(config, angle);
        }


    }
}
