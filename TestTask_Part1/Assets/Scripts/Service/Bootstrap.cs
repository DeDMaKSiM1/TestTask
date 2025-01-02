using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _templateSprite;
    [SerializeField] private Transform _playerSpawnPosition;
    [SerializeField] private Transform _enemySpawnPosition;
    private void Awake()
    {
        CreateGameSession();

        var playerSpawnConfig = Resources.Load<SpawnConfig>("PlayerConfig");
        var enemySpawnConfig = Resources.Load<SpawnConfig>("EnemyConfig");

        var playerSpawnComponent = new SpawnComponent();
        var enemySpawnComponent = new SpawnComponent();

        var camera = new CameraAdjuster(_templateSprite);
        camera.AdjustCameraToBackground();


        playerSpawnComponent.SpawnToPosition(playerSpawnConfig.Prefab.name, _playerSpawnPosition.position);
        enemySpawnComponent.SpawnToPosition(enemySpawnConfig.Prefab.name, _enemySpawnPosition.position);
    }
    private void CreateGameSession()
    {
        if (FindAnyObjectByType<GameSession>() != null)
            return;
        var gameSessionSpawner = new SpawnComponent();
        gameSessionSpawner.Spawn("GameSession");
    }
}
