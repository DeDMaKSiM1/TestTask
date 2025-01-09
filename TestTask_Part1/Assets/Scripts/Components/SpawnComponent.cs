using Interfaces;
using UnityEngine;
using Zenject;

namespace Components
{
    public class SpawnComponent 
    {
        [Inject]
        private DiContainer _diContainer;

        //[Inject]
        //private void Construct(DiContainer diContainer)
        //{
        //    _diContainer = diContainer;
        //}

        public GameObject SpawnToPosition(GameObject gameObject)
        {
            return _diContainer.InstantiatePrefab(gameObject);
        }
    }
}
