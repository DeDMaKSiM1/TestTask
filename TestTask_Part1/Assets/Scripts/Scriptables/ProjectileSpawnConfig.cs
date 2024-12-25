using UnityEngine;

[CreateAssetMenu(fileName = "NewProjectile", menuName = "Projectiles/DefaultProjectile")]
public class ProjectileSpawnConfig : SpawnConfig
{
    public GameObject ProjectilePrefab;
    public float ProjectileHealth;
    public float ProjectileSpeed;
}
