using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    private Vector3 movement;
    public float walkSpeed = 5f;
    //private float lerpValue;
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        //lerpValue = Time.deltaTime * walkSpeed;
        Vector3 movement = new Vector3(walkSpeed * inputX, walkSpeed * inputY, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}

