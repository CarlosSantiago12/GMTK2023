using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mega_script : MonoBehaviour
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
        if(!Bools.pressedMega){
        if(Bools.Mega)
        {
            Score.IncreaseScore(10f);
        }
        else
        {
            Score.IncreaseScore(-5f);
        }
        audioSource.PlayOneShot(soundEffect); // Play the sound effect
        GetComponent<Button>().interactable = false;
        Bools.pressedMega=true;
        Bools.count+=1;
        }
    }
}

