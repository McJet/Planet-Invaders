using UnityEngine;

public class MouseFollowScript : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public Transform startPosition;

    Vector3 mousePosition;
    Rigidbody2D rb;
    Vector2 position;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}