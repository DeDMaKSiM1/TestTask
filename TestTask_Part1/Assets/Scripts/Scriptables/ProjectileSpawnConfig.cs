using UnityEngine;

[CreateAssetMenu(fileName = "NewProjectile", menuName = "Projectiles/DefaultProjectile")]
public class ProjectileSpawnConfig : SpawnConfig
{
    public float ProjectileHealth;
    public float ProjectileSpeed;
}
