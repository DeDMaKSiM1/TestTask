using UnityEngine;

public class PlayerConfigLoader : IConfigLoader
{
    public CharacterSpawnConfig LoadCharacterConfig()
    {
        return Resources.Load<CharacterSpawnConfig>("PlayerConfig");
    }

    public ProjectileSpawnConfig LoadProjectileConfig()
    {
        return Resources.Load<ProjectileSpawnConfig>("PlayerProjectileConfig");
    }
}
