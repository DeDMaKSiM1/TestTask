
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
    public void ProjectileInit(ProjectileConfig config, float angle)
    {
        _heatlh = config.ProjectileHealth;
        _speed = config.ProjectileSpeed;
        var directionToMouse = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad)).normalized;
        rbody.AddForce(directionToMouse * _speed, ForceMode2D.Impulse);
    }
    public void ApplyDamage()
    {
        Debug.Log("Урон получен");
    }
}

