
using UnityEngine;

public interface IConfigLoader
{
    public CharacterSpawnConfig LoadCharacterConfig();
    public ProjectileSpawnConfig LoadProjectileConfig();
}

