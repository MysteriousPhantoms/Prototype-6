using UnityEngine;
using UnityEngine.InputSystem;

public class TimeLoopTrigger : MonoBehaviour
{
    public Transform startPoint;

    private GameObject player;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            rb = player.GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (player == null)
            {
                Debug.Log("Player is missing. Check the Player tag.");
                return;
            }

            if (startPoint == null)
            {
                Debug.Log("Assign the Start Point in the Inspector.");
                return;
            }

            player.transform.position = startPoint.position;

            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.angularVelocity = 0f;
            }

            LoopCounter counter = FindFirstObjectByType<LoopCounter>();

            if (counter != null)
            {
                counter.AddLoop();
            }

            Debug.Log("TIME LOOP ACTIVATED!");
        }
    }

}
