using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAgent : MonoBehaviour
{
    // reference to the roller ball
    Rigidbody rBody;

    // receive input and apply to the world
    public float forceMultiplier = 10;

    // set reference to Rigidbody
    void Start()
    {
        rBody = GetComponent<Rigidbody>();        
    }

    void FixedUpdate()
    {
        rBody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * forceMultiplier);
    }

    //// intiialize everything at start of each episode
    //public override void Start()
    //{
    //    // reset agent to center of floor if it falls
    //    if (this.transform.localPosition.y < 0)
    //    {
    //        this.rBody.angularVelocity = Vector3.zero;
    //        this.rBody.velocity = Vector3.zero;
    //        this.transform.localPosition = new Vector3(0, 0.5f, 0);
    //    }
    //}

    // add keyboard controls
    //public override void Heuristic(in ActionBuffers actionsOut)
    //{
    //    Debug.Log("am I being called?");
    //    var continuousActionsOut = actionsOut.ContinuousActions;
    //    continuousActionsOut[0] = Input.GetAxis("Horizontal");
    //    continuousActionsOut[1] = Input.GetAxis("Vertical");
    //}
}
