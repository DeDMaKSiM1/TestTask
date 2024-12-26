
using UnityEngine;

public class ProjectileInstantiater : MonoBehaviour
{
    private Rigidbody2D rbody;
    private float _heatlh;
    private float _speed;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();

    }
    public void ProjectileInit(ProjectileSpawnConfig config, Vector3 directionToMouse)
    {
        _heatlh = config.ProjectileHealth;
        _speed = config.ProjectileSpeed;
        rbody.AddForce(directionToMouse * _speed);
    }
    public void ApplyDamage()
    {
        Debug.Log("Урон принят");
    }
}

