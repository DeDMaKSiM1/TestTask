
using UnityEngine;

public interface IConfigLoader
{
    public T LoadConfig<T>(string path) where T : ScriptableObject;
}

