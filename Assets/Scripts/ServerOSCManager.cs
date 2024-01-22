using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Avatar2;
using extOSC;
using extOSC.Core;

public class ServerOSCManager : MonoBehaviour
{
    public MasterControl masterControl;

    [Header("Avatar")]
    public OvrAvatarEntity avatar1;
    public OvrAvatarEntity avatar2;

    [Header("Stream")]
    public byte[] avatarStreamData1;
    public byte[] avatarStreamData2;

    public byte[] oneWayLatencyData1;
    public byte[] oneWayLatencyData2;

    public byte[] returnLatencyData1;
    public byte[] returnLatencyData2;

    [Header("Head")]
    public Vector3 headPosition1;
    public Vector3 headRotation1;
    public Vector3 headPosition2;
    public Vector3 headRotation2;

    //to send to reaper
  //  [HideInInspector]
    public float yaw1;
 //   [HideInInspector]
    public float pitch1;
  //  [HideInInspector]
    public float roll1;
 //   [HideInInspector]
    public float yaw2;
 //   [HideInInspector]
    public float pitch2;
  //  [HideInInspector]
    public float roll2;

    [Header("Chest")]
    public Vector3 chestPosition1;
    public Vector3 chestRotation1;
    public Vector3 chestPosition2;
    public Vector3 chestRotation2;

    [Header("Left Hand")]
    public Vector3 leftHandPosition1;
    public Vector3 leftHandRotation1;
    public Vector3 leftHandPosition2;
    public Vector3 leftHandRotation2;

    [Header("Right Hand")]
    public Vector3 rightHandPosition1;
    public Vector3 rightHandRotation1;
    public Vector3 rightHandPosition2;
    public Vector3 rightHandRotation2;

    [Header("Gaze")]
    public Vector3 gazeRotation1;
    public Vector3 gazeRotation2;

    [Header("Brows")]
    public float browLowererL1;
    public float browLowererR1;
    public float browLowererL2;
    public float browLowererR2;
    public float innerBrowRaiserL1;
    public float innerBrowRaiserR1;
    public float innerBrowRaiserL2;
    public float innerBrowRaiserR2;
    public float outerBrowRaiserL1;
    public float outerBrowRaiserR1;
    public float outerBrowRaiserL2;
    public float outerBrowRaiserR2;

    [Header("Lips")]
    public float lipCornerPullerL1;
    public float lipCornerPullerR1;
    public float lipCornerPullerL2;
    public float lipCornerPullerR2;

    [Header("Timestamp")]
    public string timeStamp1;
    public string timeStamp2;

    [Header("Latency")]
    public double latency1;
    public double latency2;

    [Header("FPS")]
    public int fPS1;
    public int fPS2;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(masterControl.readyToStream)
        {
            avatar1.ApplyStreamData(avatarStreamData1);
            avatar2.ApplyStreamData(avatarStreamData2);
        }

        //to send to reaper
        yaw1 = headRotation1.y;
        pitch1 = headRotation1.x;
        roll1 = headRotation1.z;

        yaw2 = headRotation2.y;
        pitch2 = headRotation2.x;
        roll2 = headRotation2.z;

        //SceneRotator plugin ranges from -180 to 180
        if (yaw1 > 180)
        {
            yaw1 = yaw1 - 360;
        }
        if (pitch1 > 180)
        {
            pitch1 = pitch1 - 360;
        }
        if (roll1 > 180)
        {
            roll1 = roll1 - 360;
        }

        if (yaw2 > 180)
        {
            yaw2 = yaw2 - 360;
        }
        if (pitch2 > 180)
        {
            pitch2 = pitch2 - 360;
        }
        if (roll2 > 180)
        {
            roll2 = roll2 - 360;
        }
        pitch1 = -pitch1;
        pitch2 = -pitch2;
    }
}
