using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class NewBehaviourScript : MonoBehaviour
{
    public float AlphaThreshold = 1;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
