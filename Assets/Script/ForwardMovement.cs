using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float speed;
    public Vector3 forward;

    void Update()
    {
        this.transform.LookAt(forward);
        this.transform.position = Vector3.MoveTowards(this.transform.position, forward, speed * Time.deltaTime);    
        //transform.Translate(speed *Time.deltaTime, 0, 0);
    }   
}
