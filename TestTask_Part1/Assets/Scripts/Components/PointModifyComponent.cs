using UnityEngine;

public class PointModifyComponent : MonoBehaviour
{
    [Range(1, 100)]
    [SerializeField] private int _value;

    public void ModifyAIScore()
    {
        GameSession.Instance.GameData.EnemyPoints += _value;
    }
    public void ModifyPlayerScore()
    {
        GameSession.Instance.GameData.PlayerPoints += _value;
    }
}
