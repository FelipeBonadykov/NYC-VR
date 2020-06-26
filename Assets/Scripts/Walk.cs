using UnityEngine;
using System.Collections;
using System;


public class Walk : MonoBehaviour
{
    public Transform moveCamera;
    public CharacterController characterController;

    private float speed = 2.5f;
    private float current;//current camera value
    private bool canMove = false;
    private DateTime time;

    void Start()
    {
        Application.targetFrameRate = 75;
    }
    // Update is called once per frame
    void Update()
    {
        // writes the value of head in angles
        current = moveCamera.eulerAngles.x;
        // step begins  head up (5 degrees)
        if (355 <= current) canMove = true;
        //check whether the person started making a step
        if (canMove & (0 < current & current <= 5)) makeStep();
        if (DateTime.Now > time & time!= DateTime.MinValue)
        {
            canMove = false;
            time = DateTime.MinValue;
        }
        // autowalk for lazy people
        if (current > 25 & current < 90) walk();
    }
    private void makeStep()
    {
        if (time==DateTime.MinValue) time = DateTime.Now.AddSeconds(0.7);
        Vector3 forward = moveCamera.TransformDirection(Vector3.forward);//get direction
        characterController.SimpleMove(forward * speed);
    }
    private void walk()
    {
        Vector3 forward = moveCamera.TransformDirection(Vector3.forward);//get direction
        characterController.SimpleMove(forward * speed);
    }
}