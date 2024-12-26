using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _templateSprite;
    [SerializeField] private Transform _playerSpawnPosition;
    [SerializeField] private Transform _enemySpawnPosition;
    private void Awake()
    {
        var playerSpawnConfig = Resources.Load<SpawnConfig>("PlayerConfig");
        var playerSpawnComponent = new SpawnComponent(playerSpawnConfig);

        var enemySpawnConfig = Resources.Load<SpawnConfig>("EnemyConfig");
        var enemySpawnComponent = new SpawnComponent(enemySpawnConfig);

        var camera = new CameraAdjuster(_templateSprite);
        camera.AdjustCameraToBackground();

        playerSpawnComponent.Spawn(_playerSpawnPosition.position);
        enemySpawnComponent.Spawn(_enemySpawnPosition.position);
    }
}
