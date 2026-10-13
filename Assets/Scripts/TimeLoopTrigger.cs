using UnityEngine;
 
public class TimeLoopTrigger : MonoBehaviour
{
    public Transform startPoint;
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("whiteM"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
 
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.angularVelocity = 0f;
            }
 
            other.transform.position = startPoint.position;
 
            FindObjectOfType<LoopCounter>().AddLoop();
        }
    }
}
