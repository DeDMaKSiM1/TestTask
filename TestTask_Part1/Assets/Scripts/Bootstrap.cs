using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
        CharacterSpawnConfig playerSpawnConfig = Resources.Load<CharacterSpawnConfig>("Configs/PlayerSpawnConfig");
        SpawnComponent playerSpawnComponent = new SpawnComponent(playerSpawnConfig);

        CharacterSpawnConfig enemySpawnConfig = Resources.Load<CharacterSpawnConfig>("Configs/EnemySpawnConfig");
        SpawnComponent enemySpawnComponent = new SpawnComponent(enemySpawnConfig);

        playerSpawnComponent.Spawn();
        enemySpawnComponent.Spawn();
    }
}
