using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This button is for testing purposes.

//It makes the fight scenes go away when they appear
public class Button_Press : MonoBehaviour
{
    public bool canContinue;
    private float delayTime =1f;

    public void OnButtonPress()
{
    StartCoroutine(OnButtonPressCoroutine());
}
   public IEnumerator OnButtonPressCoroutine()
   {
        Debug.Log("Still working");
      canContinue = true;
      yield return new WaitForSeconds(delayTime);
      canContinue = false;
      

   }
}
