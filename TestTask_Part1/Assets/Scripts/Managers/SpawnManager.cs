using Characters;
using Components;
using Configs;
using UnityEngine;

namespace Managers
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private Transform _playerPosition;
        [SerializeField] private Transform _enemyPosition;

        public void CharacterSpawn(GameRulesConfig config)
        {
            SpawnComponent spawnComponent = new();
            var playerPrefab = spawnComponent.SpawnToPosition(config.PlayerConfig.Prefab, _playerPosition.position, Quaternion.identity);
            var enemyPrefab = spawnComponent.SpawnToPosition(config.EnemyConfig.Prefab, _enemyPosition.position, Quaternion.identity);

            SendConfig(playerPrefab, config.PlayerConfig);
            SendConfig(enemyPrefab, config.EnemyConfig);
        }

        private void SendConfig(GameObject characterPrefab, CharacterConfig charConfig)
        {
            var character = characterPrefab.GetComponent<Character>();
            character.GetConfigData(charConfig);
        }
    }
}
