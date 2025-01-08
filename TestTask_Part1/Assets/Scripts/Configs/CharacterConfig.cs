using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Configs/Character")]
    public class CharacterConfig : GameConfig
    {
        public WeaponConfig WeaponConfig;
    }
}
