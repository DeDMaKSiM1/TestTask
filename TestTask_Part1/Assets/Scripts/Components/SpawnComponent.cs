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
    public GameObject Spawn(Vector3 positionSpawn)
    {
        string characterName = _config.Name;

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
        // Здесь может конфиг прям передавать в заспавленный объект?
        return Object.Instantiate(objectToSpawn, positionSpawn, Quaternion.identity);
    }
}
