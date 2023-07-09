using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Fight_Screen : MonoBehaviour
{

    public R_E_Punch R_E_Punch;
    public L_F_Kick L_F_Kick;
    public R_W_Knee R_W_Knee;
    public L_E_Kick L_E_Kick;
    public R_E_Kick R_E_Kick;
    public L_F_Knee L_F_Knee;
    public R_W_Punch R_W_Punch;
    public L_E_Knee L_E_Knee;
    public R_F_Knee R_F_Knee;
    public L_W_Punch L_W_Punch;
    public R_F_Kick R_F_Kick;
    public L_E_Punch L_E_Punch;
    public R_W_Kick R_W_Kick;
    public L_W_Knee L_W_Knee;
    public R_F_Punch R_F_Punch;
    public L_F_Punch L_F_Punch;
    public R_E_Knee R_E_Knee;
    public float totalTime; // Total time in seconds
    public float currentTime;
    public float count;

    public Main_Menu end;
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip soundEffect; // Sound effect to play
    public AudioSource audioSource2; // Reference to the AudioSource component
    public AudioClip soundEffect2; // Sound effect to play

    private void Start()
    {
        currentTime = totalTime;
    }

    private void Update()
    {
        //Right Electric Punch actives first
        if (currentTime > 0 && count == 0)
        {
            currentTime -= Time.deltaTime;

            // You can perform actions or update UI based on the current time here
            //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

            if (currentTime <= 0)
            {
                // Timer has reached zero, perform any necessary actions
                //Debug.Log("Time's up!");
                //Here is where the magic happens
                audioSource.PlayOneShot(soundEffect);
                StartCoroutine(R_E_Punch.DisplayPictureCoroutine());
                count+= 1; //So that Pow_3 can activate after this one
            }
        }

        else if (currentTime > 0 && count == 1)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_F_Kick.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }
            else if (currentTime > 0 && count == 2)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_W_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 3)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_E_Kick.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 4)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_E_Kick.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 5)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_F_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 6)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_W_Punch.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 7)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_E_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 8)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_F_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 9)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_W_Punch.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 10)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_F_Kick.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 11)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_E_Punch.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 12)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_W_Kick.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 13)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_W_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 14)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_F_Punch.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 15)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(L_F_Punch.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }else if (currentTime > 0 && count == 16)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                //Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    //Debug.Log("Time's up!");
                    //Here is where the magic happens
                    audioSource.PlayOneShot(soundEffect);
                    StartCoroutine(R_E_Knee.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }
        else if(count == 17){
            //Debug.Log("Finished");
           StartCoroutine(EndGameCoroutine());
        }
         
    }
    private IEnumerator EndGameCoroutine()
    {
        count+=1;
        audioSource2.PlayOneShot(soundEffect2);
        yield return new WaitForSeconds(8f); // Delay for 2 seconds

        // Call the End method in the EndScript
        end.End();
    }
}
