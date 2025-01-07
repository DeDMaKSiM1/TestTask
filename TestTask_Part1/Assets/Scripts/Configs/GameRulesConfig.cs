using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewGameRules", menuName = "Configs/GameRules")]
    public class GameRulesConfig : ScriptableObject
    {
        public CharacterConfigs PlayerConfig;
        public CharacterConfigs EnemyConfig;
    }
}
