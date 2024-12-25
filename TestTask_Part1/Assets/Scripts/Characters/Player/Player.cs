using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rbody;
    private Vector2 _direction;

    private IConfigLoader _configLoader;
    private ProjectileSpawnConfig _projectileConfig;

    private SpawnComponent _spawnComponent;
    private ProjectileSpawnConfig _projectileSpawnConfig;


    private void Start()
    {
        _configLoader = new PlayerConfigLoader();

        _rbody = GetComponent<Rigidbody2D>();
        _projectileSpawnConfig = Resources.Load<ProjectileSpawnConfig>("Configs/Projectiles/PlayerProjectileConfig");
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
        var projectilePrefab = _spawnComponent.Spawn(transform.position);
        if(!projectilePrefab.TryGetComponent<ProjectileInstantiater>(out var projectileInit))
        {
            Debug.Log("Ошибка при инстанте снаряда");
            return;
        }
        Debug.Log(_direction);
        var test = _configLoader.LoadProjectileConfig();
        projectileInit.ProjectileInit(test, _direction);
    }
}
