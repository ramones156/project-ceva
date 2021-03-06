using UnityEngine;
using UnityEngine.Events;

public struct RackData
{
    public int number;
    public Color color;
    public Letter letter;

    public override string ToString()
    {
        return $"{letter}{number}";
    }
}

public class PlayerController : MonoBehaviour
{
    public float speed = 400f;
    public UnityEvent<RackData> headBang;
    private Rigidbody _rb;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Rack"))
        {
            var scriptOther = other.gameObject.GetComponent<Rack>();
            // Event pushen
            headBang.Invoke(new RackData
                { number = scriptOther.number, color = scriptOther.color, letter = scriptOther.letter });
        }
    }

    public void Move(Vector3 movement)
    {
        _rb.velocity = movement * speed;
    }
}