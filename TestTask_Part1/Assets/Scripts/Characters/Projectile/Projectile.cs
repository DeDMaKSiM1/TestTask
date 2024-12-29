
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
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
        GameSession.Instance.GameData.PlayerPoints += 10;
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}

