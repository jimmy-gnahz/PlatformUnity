using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theLedge;

    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }
}
