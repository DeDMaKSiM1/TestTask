using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent 
{
    private readonly SpawnConfig _config;

    private readonly static Dictionary<string, GameObject> _prefabCache = new();

    public SpawnComponent(SpawnConfig config)
    {
        _config = config;
    }
    public SpawnComponent() { } 
    public GameObject SpawnCharacter(Vector3 positionSpawn)
    {
        string characterName = _config.Prefab.name;

        if (!_prefabCache.TryGetValue(characterName, out GameObject objectToSpawn))
        {
            objectToSpawn = _config.Prefab;
            if (objectToSpawn == null)
            {
                Debug.LogError($"Object {characterName} not found in Resources");
                return default;
            }
            _prefabCache[characterName] = objectToSpawn;
        }

        return Object.Instantiate(objectToSpawn, positionSpawn, Quaternion.identity);
    }
    public GameObject Spawn(GameObject gameObject)
    {
        return Object.Instantiate(gameObject);
    }
}
