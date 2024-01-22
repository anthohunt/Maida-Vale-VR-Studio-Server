using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// manages the active instruments and control transform when selected in master control

public class InstrumentManager : MonoBehaviour
{
    public MasterControl masterControl;

    public int instrumentID1 = 0;
    public int instrumentID2 = 0;

  //  public Transform piano1;
    public Transform guitar1;
   // public Transform piano2;
    public Transform guitar2;

    public Vector3 activeInstrumentPos1;
    public Vector3 activeInstrumentRot1;
    public Vector3 activeInstrumentScale1;

    public Vector3 activeInstrumentPos2;
    public Vector3 activeInstrumentRot2;
    public Vector3 activeInstrumentScale2;

    private void Update()
    {
        //piano 1
        if(instrumentID1 == 1) //info given by client
        {
            //spawn piano 1
        //    piano1.gameObject.SetActive(true);
            guitar1.gameObject.SetActive(false);

            // client control
            if (!masterControl.freezeClientObjects)
            {
           //     piano1.position = activeInstrumentPos1;
           //     piano1.eulerAngles = activeInstrumentRot1;
             //   piano1.localScale = activeInstrumentScale1;
            }
            // server control
            if (masterControl.freezeClientObjects)
            {
               // activeInstrumentPos1 = piano1.position;
               // activeInstrumentRot1 = piano1.eulerAngles;
               // activeInstrumentScale1 = piano1.localScale;
            }
        }
        //guitar 1
        else if (instrumentID1 == 2) //info given by client
        {
            //spawn guitar 1
        //    piano1.gameObject.SetActive(false);
            guitar1.gameObject.SetActive(true);

            // client control
            if (!masterControl.freezeClientObjects)
            {
                guitar1.position = activeInstrumentPos1;
                guitar1.eulerAngles = activeInstrumentRot1;
                guitar1.localScale = activeInstrumentScale1;
            }

            // server control
            if (masterControl.freezeClientObjects)
            {
                activeInstrumentPos1 = guitar1.position;
                activeInstrumentRot1 = guitar1.eulerAngles;
                activeInstrumentScale1 = guitar1.localScale;
            }
        }

        //piano 2
        if (instrumentID2 == 1) //info given by client
        {
            //spawn piano 2
         //   piano2.gameObject.SetActive(true);
            guitar2.gameObject.SetActive(false);

            // client control
            if (!masterControl.freezeClientObjects)
            {
             //   piano2.position = activeInstrumentPos2;
            //    piano2.eulerAngles = activeInstrumentRot2;
             //   piano2.localScale = activeInstrumentScale2;
            }

            // server control
            if (masterControl.freezeClientObjects)
            {
            //    activeInstrumentPos2 = piano2.position;
             //   activeInstrumentRot2 = piano2.eulerAngles;
              //  activeInstrumentScale2 = piano2.localScale;
            }
        }
        //guitar 2
        else if (instrumentID2 == 2) //info given by client
        {
            //spawn guitar 2
        //    piano2.gameObject.SetActive(false);
            guitar2.gameObject.SetActive(true);

            // client control
            if (!masterControl.freezeClientObjects)
            {
                guitar2.position = activeInstrumentPos2;
                guitar2.eulerAngles = activeInstrumentRot2;
                guitar2.localScale = activeInstrumentScale2;
            }

            // server control
            if (masterControl.freezeClientObjects)
            {
                activeInstrumentPos2 = guitar2.position;
                activeInstrumentRot2 = guitar2.eulerAngles;
                activeInstrumentScale2 = guitar2.localScale;
            }
        }
    }
}
