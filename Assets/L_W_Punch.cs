using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_W_Punch : MonoBehaviour
{
        public GameObject pictureObject;
    public float newTime;
    public float delayTime;

    //canClick is a boolean that enables and disables the Buttons
    //They are enabled when the fight scene image comes out and disabled when it leaves 
    public bool canClick;

    public Timer_Fight_Screen timerFightScreen;
    public Bool_Manager Bools;
    public Shading shade;
    public IEnumerator DisplayPictureCoroutine()
    {
        // Show the image
        pictureObject.SetActive(true); 
        //Lets you click the screen
        shade.offShade();
        //Buttons pressable with canClick = true
        canClick = true;
        //Set Button Bools.
        Bools.Fire = false;
        Bools.Water = true;
        Bools.Electric = false;
        Bools.Punch = true;
        Bools.Kick = false;
        Bools.Knee = false;

        while (delayTime > 0)
        {
            delayTime -= Time.deltaTime;
            if (Bools.allSelected)
            {
                delayTime = 0f;
            }

            yield return null; // Yield control back to Unity
        }
        //Turn unclickable back on
        shade.onShade();
        //Turn of image
        pictureObject.SetActive(false); // Hide the picture
        //Reset count in Bool_Manager
        Bools.count = 0;
        Bools.resetPressed();
        //Can't click other buttons anymore
        canClick = false;

        timerFightScreen.currentTime = newTime;
    }
}
