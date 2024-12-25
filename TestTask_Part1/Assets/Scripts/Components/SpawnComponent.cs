using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private Characters _characterToSpawn;

    private static Dictionary<string, GameObject> _prefabCache = new Dictionary<string, GameObject>();

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        string characterName = _characterToSpawn.ToString();

        if (!_prefabCache.TryGetValue(characterName, out GameObject objectToSpawn))
        {
            objectToSpawn = Resources.Load<GameObject>(characterName);
            if (objectToSpawn == null)
            {
                Debug.LogError($"Object {characterName} not found in Resources");
                return;
            }
            _prefabCache[characterName] = objectToSpawn;
        }

        Instantiate(objectToSpawn);
    }
}
