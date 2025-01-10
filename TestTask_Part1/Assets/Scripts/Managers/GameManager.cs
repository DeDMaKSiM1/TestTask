using Characters;
using Components;
using Configs;
using Managers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Sub Managers")]
    [SerializeField] private SpawnManager _spawnManager;

    [Header("Spawn Position")]
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private Transform _enemyPosition;

    private GameRulesConfig _gameRulesConfig;
    private GameObject player;
    private GameObject enemy;

    private void Awake()
    {
        _gameRulesConfig = Resources.Load<GameRulesConfig>("GameRules");

        player = _spawnManager.CharacterSpawn(_gameRulesConfig.PlayerConfig.Prefab, _playerPosition.position);
        enemy = _spawnManager.CharacterSpawn(_gameRulesConfig.EnemyConfig.Prefab, _enemyPosition.position);
    }

 
    public void RebootTransform()
    {
        player.transform.position = _playerPosition.position;
        enemy.transform.position = _enemyPosition.position;
    }

}
