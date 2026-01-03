using UnityEngine;

public class FuelBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Movement move;
    public float maxWidth;
    public float minWidth;
    public RectTransform tf;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float width = move.fuel / move.capacity * maxWidth;
        if (width >= minWidth)
        {
            tf.sizeDelta = new Vector2(width, 100);
        }
    }
}
