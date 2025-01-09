using UnityEngine;

namespace  Configs
{
    public abstract class GameObjectConfig : ScriptableObject
    {
        public GameObject Prefab;
        public float Speed;
    }
}
