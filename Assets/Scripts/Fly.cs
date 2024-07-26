using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

    public Transform head;

    public OVRHand leftHand;
    public OVRHand rightHand;

    private bool isFlying = false;

    // Update is called once per frame
    void Update()
    {
        if (!isFlying)
        {
            isFlying = !isFlying;
        }
    
            
        if (isFlying)
        {
            Vector3 leftDir = leftHand.transform.position - head.position;
            Vector3 rightDir = rightHand.transform.position - head.position;

            Vector3 dir = leftDir + rightDir;

            transform.position += (dir * .1f);
        }
    }
}
