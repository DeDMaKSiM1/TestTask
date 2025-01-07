using UnityEngine;

public class GenericConfigLoader : IConfigLoader
{
    public T LoadConfig<T>(string path) where T : ScriptableObject
    {
        return Resources.Load<T>(path);
    }
}
