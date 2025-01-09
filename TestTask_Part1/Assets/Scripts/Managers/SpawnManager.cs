using Characters;
using Components;
using Configs;
using System.ComponentModel;
using UnityEngine;
using Zenject;

namespace Managers
{
    public class SpawnManager : MonoBehaviour
    {
        private SpawnComponent _spawnComponent;

        [Inject]
        private void Construct(SpawnComponent spawnComponent)
        {
            _spawnComponent = spawnComponent;
        }

        public GameObject CharacterSpawn(GameObject prefab, Vector2 position)
        {
            return _spawnComponent.SpawnToPosition(prefab);
        }

    }
}
