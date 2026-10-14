using UnityEngine;
 
public class WinZone : MonoBehaviour
{
    public GameObject winScreen;
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
        }
    }
}
