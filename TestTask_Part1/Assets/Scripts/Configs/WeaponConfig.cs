using Components;
using Interfaces;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Configs/Weapon")]
    public class WeaponConfig : GameObjectConfig
    {
        public Weapon Weapon;
    }
}
