using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rbody;
    private Vector2 _direction;

    private SpawnComponent _spawnComponent;
    private ProjectileSpawnConfig _projectileSpawnConfig;


    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _projectileSpawnConfig = Resources.Load<ProjectileSpawnConfig>("Configs/PlayerProjectileSpawnConfig");
        _spawnComponent = new SpawnComponent(_projectileSpawnConfig);
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (_direction != Vector2.zero)
            _rbody.MovePosition(_rbody.position + _speed * Time.fixedDeltaTime * _direction);
    }
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
    public void Attack()
    {
        Debug.Log("Атака");
    }
}
