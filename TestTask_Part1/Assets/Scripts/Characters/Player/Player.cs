using Components;
using UnityEngine;

namespace Characters
{
    public class Player : Character
    {
        private float _angleToMousePosition;
        private Vector2 _direction;

 
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
                _rb.MovePosition(_rb.position + _speed * Time.fixedDeltaTime * _direction);
            else
                _rb.linearVelocity = Vector2.zero;

        }

        private void RotatePlayer()
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var directionToMouse = mousePosition - transform.position;
            _angleToMousePosition = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, _angleToMousePosition));
        }
        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }
    }
}
