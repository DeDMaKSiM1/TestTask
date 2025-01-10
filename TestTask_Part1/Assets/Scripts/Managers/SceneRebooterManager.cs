
using UnityEngine;

namespace  Scripts
{
    public class SceneRebooterManager : MonoBehaviour
    {
        private GameManager _gameManager;
        private void Awake()
        {
            _gameManager = GetComponent<GameManager>();
        }
        public void RebootScene()
        {
            _gameManager.RebootTransform();
        }
    }
}
