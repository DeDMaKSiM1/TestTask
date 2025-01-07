using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewGameRules", menuName = "Configs/GameRules")]
    public class GameRulesConfig : ScriptableObject
    {
        public CharacterConfig PlayerConfig;
        public CharacterConfig EnemyConfig;
    }
}
