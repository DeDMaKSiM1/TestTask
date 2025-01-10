using UnityEngine.SceneManagement;

namespace  Components
{
    public class SceneManagerComponent
    {
        private SceneManager sceneManager;
        
        public void ChangeScene()
        {
            var currentScene = SceneManager.GetActiveScene();
            SceneManager.SetActiveScene(currentScene);
        }
    }
}
