using Configs;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected Transform _projectileSpawnPosition;

    protected float _speed;
    protected Rigidbody2D _rb;
    public float Speed
    {
        get => _speed;
        set
        {
            if (value < 1)
            {
                _speed = 1;
                return;
            }
            _speed = value;
        }
    }


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void GetConfigData(CharacterConfig config)
    {
        Speed = config.Speed;
    }
}
