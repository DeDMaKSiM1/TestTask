using Interfaces;
using UnityEngine;
using Zenject;

namespace Components
{
    public class SpawnComponent
    {
        [Inject]
        private DiContainer _diContainer;



        public GameObject SpawnToPosition(GameObject gameObject, Vector3 position)
        {
            var parameters = new GameObjectCreationParameters { Position = position };
            return _diContainer.InstantiatePrefab(gameObject , parameters);
        }
    }
}
