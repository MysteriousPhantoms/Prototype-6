using UnityEngine;
using TMPro;
 
public class LoopCounter : MonoBehaviour
{
    public static int loops = 0;
 
    public TextMeshProUGUI loopText;
 
    void Start()
    {
        UpdateText();
    }
 
    public void AddLoop()
    {
        loops++;
        UpdateText();
    }
 
    void UpdateText()
    {
        loopText.text = "Loops: " + loops;
    }
}
