using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonActions : MonoBehaviour
{
    public Canvas instructions;
    public Transform rayInfo;
    public float x, y;
 
    // Update is called once per frame
    void Update()
    {
        x = rayInfo.rotation.x;
        y = rayInfo.rotation.y;
        if (.13 <= x & x <= .17 &
            .06 <= y & y <= .21)
            instructions.gameObject.SetActive(false);
    }
}
