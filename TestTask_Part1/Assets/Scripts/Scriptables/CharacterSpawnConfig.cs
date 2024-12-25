using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Character")]
public class CharacterSpawnConfig : ScriptableObject
{
    public string Name;
    public GameObject Prefab;
    public Vector2 SpawnPosition;
}
