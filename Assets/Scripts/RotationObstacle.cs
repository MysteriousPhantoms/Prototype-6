using UnityEngine;
 
public class RotationObstacle : MonoBehaviour
{
    public float rotationSpeed = 100f;
 
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
