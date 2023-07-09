using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knee_script : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip soundEffect; // Sound effect to play
    public Bool_Manager Bools;
    public Game_Score Score;
    private void Update() {
        if(Bools.count==0)
        {
            GetComponent<Button>().interactable = true;
        }
    }
    public void OnClick()
    {
        if(!Bools.pressedKnee){
        if(Bools.Knee)
        {
            Score.IncreaseScore(10f);
        }
        else
        {
            Score.IncreaseScore(-5f);
        }
        audioSource.PlayOneShot(soundEffect); // Play the sound effect
        GetComponent<Button>().interactable = false;
        Bools.pressedKnee=true;
        Bools.count+=1;
        }
    }
}

