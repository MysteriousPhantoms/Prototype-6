using UnityEngine;

public class Trail : MonoBehaviour
{
    public float widthRate;
    
    private SpriteRenderer sRend;
    private TrailRenderer tRend;

    private bool changingColor;
    
    public bool specColor;
    public Color setColor;
    
    private void Start() {
        MarbleColor();
        
    }

    public void MarbleColor()
    {
        sRend = GetComponent<SpriteRenderer>();
        tRend = GetComponent<TrailRenderer>();

        if(!specColor) { setColor = sRend.color;}
    
    tRend.startColor = setColor;
    tRend.endColor = new Color(setColor.r, setColor.g, setColor.b, 0f);
	tRend.startWidth = base.transform.localScale.x * widthRate;
    }

    private void Update()
	{
		if (changingColor)
		{
			tRend.startColor = sRend.color;
			tRend.endColor = new Color(sRend.color.r, sRend.color.g, sRend.color.b,0f);
		}
	}

}
