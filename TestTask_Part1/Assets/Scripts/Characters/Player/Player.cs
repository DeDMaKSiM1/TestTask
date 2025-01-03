using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _projectileSpawnPosition;

    private float angleToMousePosition;
    private Rigidbody2D _rbody;
    private SpawnComponent _spawnComponent;
    private ProjectileConfig _projectileSpawnConfig;
    private Vector2 _direction;
    private IConfigLoader _configLoader;

    private const string ProjectileConfigPath = "PlayerProjectileConfig";
    private void Start()
    {
        _configLoader = new GenericConfigLoader();
        _rbody = GetComponent<Rigidbody2D>();

        _projectileSpawnConfig = _configLoader.LoadConfig<ProjectileConfig>(ProjectileConfigPath);
        _spawnComponent = new SpawnComponent();
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
        else
            _rbody.linearVelocity = Vector2.zero;

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
        var projectilePrefab = _spawnComponent.SpawnToPosition(_projectileSpawnConfig.Prefab.name, _projectileSpawnPosition.position);
        if (!projectilePrefab.TryGetComponent<Projectile>(out var projectileInit))
        {
            Debug.Log("������ ��� �������� �������");
            return;
        }

        projectileInit.ProjectileInit(_projectileSpawnConfig, angleToMousePosition);
    }
}
