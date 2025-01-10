

using UnityEngine;
using Zenject;

namespace  Scripts
{
    public class SceneRebootingComponent : MonoBehaviour
    {
        [Inject]
        private SceneRebooterManager sceneRebuildManager;

        public void Reboot()
        {
            sceneRebuildManager.RebootScene();
        }
    }
}
