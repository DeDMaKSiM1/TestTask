using UnityEngine;

public class PlayerConfigLoader : IConfigLoader
{
    public CharacterSpawnConfig LoadCharacterConfig()
    {
        return Resources.Load<CharacterSpawnConfig>("Configs/Characters/PlayerConfig");
    }

    public ProjectileSpawnConfig LoadProjectileConfig()
    {
        return Resources.Load<ProjectileSpawnConfig>("Configs/Projectiles/PlayerProjectileConfig");
    }
}
