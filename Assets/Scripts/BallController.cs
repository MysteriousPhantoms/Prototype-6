using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float jumpForce = 7f;
    public int maxJumps = 3;

    public GameObject platformPrefab;
    public float platformLifetime = 5f;

    private Rigidbody2D rb;
    private int jumpsUsed = 0;
    private bool grounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Roll left and right
        float move = 0f;

        if (Keyboard.current.aKey.isPressed ||
            Keyboard.current.leftArrowKey.isPressed)
            move = -1f;

        if (Keyboard.current.dKey.isPressed ||
            Keyboard.current.rightArrowKey.isPressed)
            move = 1f;

        rb.AddForce(Vector2.right * move * moveSpeed);

        // Jump up to 3 times
        if (Keyboard.current.wKey.wasPressedThisFrame ||
            Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            if (jumpsUsed < maxJumps)
            {
                rb.linearVelocity = new Vector2(
                    rb.linearVelocity.x, jumpForce);

                jumpsUsed++;
                grounded = false;
            }
        }

        // Spawn a temporary platform with E
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (jumpsUsed < maxJumps && platformPrefab != null)
            {
                Vector3 spawnPosition =
                    transform.position + new Vector3(1.2f, -0.5f, 0f);

                GameObject platform = Instantiate(
                    platformPrefab, spawnPosition, Quaternion.identity);

                Destroy(platform, platformLifetime);
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f)
            {
                grounded = true;
                jumpsUsed = 0;
                return;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}
