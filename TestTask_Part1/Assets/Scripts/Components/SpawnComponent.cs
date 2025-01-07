using UnityEngine;

public class SpawnComponent
{
    public GameObject SpawnToPosition(GameObject gameobject, Vector2 position, Quaternion quaternion)
    { 
        return Object.Instantiate(gameobject, position, quaternion);
    }
    public GameObject Spawn(GameObject gameobject)
    { 
        return Object.Instantiate(gameobject);
    }
}
