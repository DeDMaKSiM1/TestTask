using Characters;
using Components;
using Configs;
using UnityEngine;

namespace Managers
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject CharacterSpawn(CharacterConfig config, Vector2 spawnPosition)
        {
            SpawnComponent spawnComponent = new();
            var spawnGameObject = spawnComponent.SpawnToPosition(config.Prefab, spawnPosition, Quaternion.identity);
            return spawnGameObject;
        }
    }
}
