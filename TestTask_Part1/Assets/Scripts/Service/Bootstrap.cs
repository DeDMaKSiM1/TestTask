using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _templateSprite;
    private void Awake()
    {
        var playerSpawnConfig = Resources.Load<CharacterSpawnConfig>("Configs/PlayerSpawnConfig");
        var playerSpawnComponent = new SpawnComponent(playerSpawnConfig);

        var enemySpawnConfig = Resources.Load<CharacterSpawnConfig>("Configs/EnemySpawnConfig");
        var enemySpawnComponent = new SpawnComponent(enemySpawnConfig);

        var camera = new CameraAdjuster(_templateSprite);
        camera.AdjustCameraToBackground();

        playerSpawnComponent.Spawn();
        enemySpawnComponent.Spawn();
    }
}
