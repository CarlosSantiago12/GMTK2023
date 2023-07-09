using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool_Manager : MonoBehaviour
{
    public bool Super;
    public bool Mega;
    public bool Ultra;
    public bool Fire;
    public bool Water;
    public bool Electric;
    public bool Punch;
    public bool Kick;
    public bool Knee;
    //Check if already pressed;
    public bool pressedSuper;
    public bool pressedMega;
    public bool pressedUltra;
    public bool pressedFire;
    public bool pressedWater;
    public bool pressedElectric;
    public bool pressedPunch;
    public bool pressedKick;
    public bool pressedKnee;

    //If allSelected is true, the count ends for the fight scenes
    public bool allSelected;

    /*When a Button is pressed, count goes up by one. 
    When it gets to 3, it means that 3 buttons where pressed.
    */
    public float count;
    //For copy pasting
    /*
            Bools.Fire = false;
            Bools.Water = false;
            Bools.Electric = false;
            Bools.Punch = false;
            Bools.Kick = false;
            Bools.Knee = false;
    */
    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(count);
        if(count==3)
        {
            //This makes the fight scene to end
            allSelected = true;
        }
        else{
            //This resets allSelected so that it doesnt close fight scenes, unwantedly
            allSelected = false;
        }
    }
    public void resetPressed()
    {
        pressedSuper = false;
        pressedMega = false;
        pressedUltra = false;
        pressedFire = false;
        pressedWater = false;
        pressedElectric = false;
        pressedPunch = false;
        pressedKick = false;
        pressedKnee = false;
    }
    //Testing purposes
    public void Print_Bools()
    {
        Debug.Log("Super=" + Super.ToString() + " Mega=" + Mega.ToString() + " Ultra=" + Ultra.ToString() + " Fire=" + Fire.ToString() + " Water=" + Water.ToString() + " Electric=" + Electric.ToString() + " Punch=" + Punch.ToString() + " Kick=" + Kick.ToString() + " Knee=" + Knee.ToString());
    }
}
