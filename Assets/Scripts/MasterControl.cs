using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterControl : MonoBehaviour
{
    [HideInInspector]
    public bool readyToStream;

    [Header("Don't touch")]
    public bool userIsPresent1;
    public bool userIsPresent2;

    [Header("OSC actions")]
    public bool freezeClientObjects; //freeze client's camera, instrument, passthrough
    public bool activateFace; //activate/deactivate face
    public bool activateBody; //activate/deactivate body

    private void FixedUpdate()
    {
        if(userIsPresent1 && userIsPresent2)
        {
            readyToStream = true;
        }
        else
        {
            readyToStream = false;
        }
    }

}
