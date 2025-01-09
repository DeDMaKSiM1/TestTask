using Components;
using Configs;
using Managers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Sub Managers")]
    [SerializeField] private SpawnManager _spawnManager;
    [SerializeField] private Injector injector;

    [Header("Spawn Position")]
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private Transform _enemyPosition;

    private GameRulesConfig _gameRulesConfig;

    private void Awake()
    {
        _gameRulesConfig = Resources.Load<GameRulesConfig>("GameRules");

        var player = _spawnManager.CharacterSpawn(_gameRulesConfig.PlayerConfig, _playerPosition.position);
        var enemy = _spawnManager.CharacterSpawn(_gameRulesConfig.EnemyConfig, _enemyPosition.position);

        injector.InitGameObject(player, _gameRulesConfig.PlayerConfig);
        injector.InitGameObject(enemy, _gameRulesConfig.EnemyConfig);
    }


}
