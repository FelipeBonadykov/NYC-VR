using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze : MonoBehaviour
{
    private Vector3 initRotation;
    public Transform transformOfCamera, transformOfPointer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        initRotation = transformOfCamera.eulerAngles;
        //actualize Y
        initRotation.x = -transformOfCamera.eulerAngles.x;
        //restore original X and Z
        transformOfPointer.eulerAngles = initRotation;
    }
}
