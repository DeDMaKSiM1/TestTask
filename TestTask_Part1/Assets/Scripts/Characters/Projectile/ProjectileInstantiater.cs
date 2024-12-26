
using Unity.VisualScripting;
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
    public void ProjectileInit(ProjectileSpawnConfig config, float angle)
    {
        _heatlh = config.ProjectileHealth;
        _speed = config.ProjectileSpeed;
        var directionToMouse = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0).normalized;
        rbody.AddForce(directionToMouse * _speed, ForceMode2D.Impulse);
    }
    public void ApplyDamage()
    {

    }
}

