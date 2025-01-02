using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent
{
    public GameObject SpawnToPosition(string PathName, Vector2 spawnPosition)
    {
        var spawnObject = Resources.Load(PathName) as GameObject;
        return Object.Instantiate(spawnObject, spawnPosition, Quaternion.identity);
    }
    public GameObject Spawn(string PathToResources)
    {
        var spawnObject = Resources.Load(PathToResources) as GameObject;
        return Object.Instantiate(spawnObject);
    }
}
