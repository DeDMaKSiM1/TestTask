using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Configs/Character")]
    public class CharacterConfig : GameObjectConfig
    {
        public WeaponConfig WeaponConfig;
    }
}
