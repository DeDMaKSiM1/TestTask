using Configs;
using Managers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SpawnManager _spawnManager;

    private GameRulesConfig _gameRulesConfig;
    private void Awake()
    {
        _gameRulesConfig = Resources.Load<GameRulesConfig>("GameRules");
        _spawnManager.Initialization(_gameRulesConfig);
    }
}
