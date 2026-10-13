using UnityEngine;
 
public class MovingObstacle : MonoBehaviour
{
    public float moveDistance = 3f;
    public float moveSpeed = 2f;
 
    private Vector3 startPos;
 
    private void Start()
    {
        startPos = transform.position;
    }
 
    private void Update()
    {
        transform.position = startPos +
            Vector3.right *
            Mathf.Sin(Time.time * moveSpeed) *
            moveDistance;
    }
}
