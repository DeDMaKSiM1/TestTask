using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Configs/Character")]
    public class CharacterConfigs : ScriptableObject
    {
        public GameObject Prefab;
    }
}
