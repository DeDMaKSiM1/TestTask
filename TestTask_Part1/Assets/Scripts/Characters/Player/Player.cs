using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _projectileSpawnPosition;

    private Rigidbody2D _rbody;
    private Vector2 _direction;
    private IConfigLoader _configLoader;

    private SpawnComponent _spawnComponent;
    private ProjectileSpawnConfig _projectileSpawnConfig;

    private float angleToMousePosition;

    private void Start()
    {
        _configLoader = new PlayerConfigLoader();

        _rbody = GetComponent<Rigidbody2D>();
        _projectileSpawnConfig = Resources.Load<ProjectileSpawnConfig>("Configs/Projectiles/PlayerProjectileConfig");
        _spawnComponent = new SpawnComponent(_projectileSpawnConfig);
    }
    private void Update()
    {
        RotatePlayer();
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
    private void RotatePlayer()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var directionToMouse = mousePosition - transform.position;
        angleToMousePosition = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angleToMousePosition));
    }
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
    public void Attack()
    {
        var projectilePrefab = _spawnComponent.Spawn(_projectileSpawnPosition.position);
        if (!projectilePrefab.TryGetComponent<ProjectileInstantiater>(out var projectileInit))
        {
            Debug.Log("Ошибка при инстанте снаряда");
            return;
        }
        //Исправить
        var test = _configLoader.LoadProjectileConfig(); 
        projectileInit.ProjectileInit(test, angleToMousePosition );
    }

}
