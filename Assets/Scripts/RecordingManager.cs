using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordingManager : MonoBehaviour
{
    public bool recordIsOn;
    private bool recordingHasStarted;
    public string participantName;
    public int take;

    private int recordingCounter;
    public string recordingTime;
    private int seconds;
    private int milliseconds;

    public float test; //to delete, testing stuff for osc for OBS


    void FixedUpdate()
    {
        if (recordIsOn)
        {
            recordingCounter++;
            seconds = recordingCounter / 100;
            milliseconds = recordingCounter % 100;
            recordingTime = $"{seconds}s {milliseconds}0ms";
            recordingHasStarted = true;
        }

        if(!recordIsOn && recordingHasStarted)
        {
            string content = "Participant name: " + participantName + ", take: " + take.ToString() + ", recording time: " + recordingTime;
            string fileName = "Recording metadata";
            System.IO.File.AppendAllText(Application.dataPath + fileName, content + Environment.NewLine);

            take++;
            recordingCounter = 0;
            recordingHasStarted = false;
        }
    }
}
