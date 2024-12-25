using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent
{
    private readonly CharacterSpawnConfig _config;

    private readonly static Dictionary<string, GameObject> _prefabCache = new();

    public SpawnComponent(CharacterSpawnConfig config)
    {
        _config = config;
    }
    public void Spawn()
    {
        string characterName = _config.Name;

        if (!_prefabCache.TryGetValue(characterName, out GameObject objectToSpawn))
        {
            objectToSpawn = _config.Prefab;
            if (objectToSpawn == null)
            {
                Debug.LogError($"Object {characterName} not found in Resources");
                return;
            }
            _prefabCache[characterName] = objectToSpawn;
        }
        var positionSpawn = _config.SpawnPosition;

        Object.Instantiate(objectToSpawn, positionSpawn, Quaternion.identity);
    }
}
