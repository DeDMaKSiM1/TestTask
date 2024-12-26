using UnityEngine;

[CreateAssetMenu(fileName = "NewProjectile", menuName = "Projectiles/DefaultProjectile")]
public class ProjectileConfig : SpawnConfig
{
    public float ProjectileHealth;
    public float ProjectileSpeed;
}
