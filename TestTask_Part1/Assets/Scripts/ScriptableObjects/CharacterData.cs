using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public GameObject prefab;
}
