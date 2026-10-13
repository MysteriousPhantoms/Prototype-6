using UnityEngine;
using UnityEngine.InputSystem;

public class TimeLoopTrigger : MonoBehaviour
{
    public Transform startPoint;

    private bool canLoop = false;

    void Update()
    {
        if (canLoop && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Rigidbody2D rb = GameObject.FindGameObjectWithTag("Player")
                .GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.angularVelocity = 0f;
            }

            rb.transform.position = startPoint.position;

            FindObjectOfType<LoopCounter>().AddLoop();

            canLoop = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("whiteM"))
        {
            canLoop = true;
            Debug.Log("Press SPACE to activate Time Loop");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("whiteM"))
        {
            canLoop = false;
        }
    }
}
