
using UnityEngine;

public class ProjectileInstantiater : MonoBehaviour
{
    private Rigidbody2D rbody;
    private float _heatlh;
    private float _speed;
    private Vector2 _direction;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();

    }
    public void ProjectileInit(ProjectileSpawnConfig config, Vector2 direction)
    {
        _heatlh = config.ProjectileHealth;
        _speed = config.ProjectileSpeed;
        _direction = direction;
        rbody.AddForce(direction * _speed);
    }
}

