
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    public GameData GameData => gameData;

    public static GameSession Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
 
