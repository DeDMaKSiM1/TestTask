using Components;
using Configs;
using Interfaces;
using UnityEngine;

namespace Managers
{
    public class Injector : MonoBehaviour
    {
        [SerializeField]
        public void InitGameObject(GameObject gameObject, GameObjectConfig config)
        {
            if (gameObject.TryGetComponent<IInitable>(out IInitable initComponent))
            {
                initComponent.Inject(config);
            }        
             
        }

    }
}
