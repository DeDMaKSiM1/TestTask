using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    [SerializeField] private Player _player;

    private PlayerInputAction _inputAction;
    private Vector2 _movement;

    private void Awake()
    {
        _inputAction = new PlayerInputAction();
        _inputAction.Player.Move.performed += OnMove;
        _inputAction.Player.Move.canceled += OnMove;
    }

    private void OnEnable()
    {
        _inputAction.Enable();
    } 
    private void OnMove(InputAction.CallbackContext context)
    {   
        _movement = context.ReadValue<Vector2>();
        _player.SetDirection(_movement);
    }
}