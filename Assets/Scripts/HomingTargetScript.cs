using UnityEngine;

public class HomingTargetScript : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public Vector3 targetPosition;

    Rigidbody2D rb;
    Vector2 position;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        position = Vector2.Lerp(transform.position, targetPosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}