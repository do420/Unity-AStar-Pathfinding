using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] Text nodeCountText;
    [SerializeField] Text durationText;


    public void SetDistance(int nodeCount, long miliseconds)
    {
        nodeCountText.text = "node count: "+ nodeCount;
        durationText.text = "Calc duration: "+miliseconds.ToString() + " ms";

    }
    
}
