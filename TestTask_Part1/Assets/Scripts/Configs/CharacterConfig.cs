using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Configs/Character")]
    public class CharacterConfig : ScriptableObject
    {
        public GameObject Prefab;
        public float Speed;
    }
}
