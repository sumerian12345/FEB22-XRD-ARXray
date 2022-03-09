using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{
    public Image iconBrain;
    public Image iconHeart;

    // Start is called before the first frame update
    void Start()
    {
        iconBrain.color = new Color(1, 1, 1, 0.3f); // whenever we select the brain, the colour transparency goes down. The 4th value is the alpha (transparency)
        iconHeart.color = new Color(1, 1, 1, 0.3f);
    }

    public void OnBrainFound()
    {
        iconBrain.color = new Color(1, 1, 1, 1);

    }

    public void OnHeartFound()
    {
        iconHeart.color = new Color(1, 1, 1, 1);
    }
}
