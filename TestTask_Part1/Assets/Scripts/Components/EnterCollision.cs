using UnityEngine;
using UnityEngine.Events;

public class EnterCollision : MonoBehaviour
{
    [SerializeField] private string _tag;
    public UnityEvent OnEnter;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_tag))
            OnEnter.Invoke();
    }
}
