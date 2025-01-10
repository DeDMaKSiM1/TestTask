using Configs;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class Projectile : MonoBehaviour
{

    private Rigidbody2D rbody;
    private float _speed;
    private float _angle;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    //В другой класс
    public void ApplyDamage()
    {
        GameSession.Instance.GameData.PlayerPoints += 10;
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    public void Launch(WeaponConfig congif, float angle)
    {
        _speed = congif.Speed;
        _angle = angle;
        LaunchProjectile();
    }
    private void LaunchProjectile()
    {
        var directionToMouse = new Vector2(Mathf.Cos(_angle * Mathf.Deg2Rad), Mathf.Sin(_angle * Mathf.Deg2Rad)).normalized;
        rbody.AddForce(directionToMouse * _speed, ForceMode2D.Impulse);

    }
}

