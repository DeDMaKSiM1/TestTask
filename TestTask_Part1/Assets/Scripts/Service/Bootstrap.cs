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
        var playerSpawnComponent = new SpawnComponent(playerSpawnConfig);

        var enemySpawnConfig = Resources.Load<SpawnConfig>("EnemyConfig");
        var enemySpawnComponent = new SpawnComponent(enemySpawnConfig);

        var camera = new CameraAdjuster(_templateSprite);
        camera.AdjustCameraToBackground();
         
        
        playerSpawnComponent.SpawnCharacter(_playerSpawnPosition.position);
        enemySpawnComponent.SpawnCharacter(_enemySpawnPosition.position);
    }
    private void CreateGameSession()
    {
        if (FindAnyObjectByType<GameSession>() != null)
            return;
        var gameSession = Resources.Load<GameObject>("GameSession");
        var gameSessionSpawner = new SpawnComponent();
        gameSessionSpawner.Spawn(gameSession);
    }
}
