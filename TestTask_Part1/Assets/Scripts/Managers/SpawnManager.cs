using Configs;
using UnityEngine;

namespace Managers
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private Transform _playerPosition;
        [SerializeField] private Transform _enemyPosition;

        public void Initialization(GameRulesConfig congif)
        {
            SpawnComponent spawnComponent = new();
            spawnComponent.SpawnToPosition(congif.PlayerConfig.Prefab, _playerPosition.position, Quaternion.identity);
            spawnComponent.SpawnToPosition(congif.EnemyConfig.Prefab, _enemyPosition.position, Quaternion.identity);
        }
    }
}
