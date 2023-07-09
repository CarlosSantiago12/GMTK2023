using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Ultra : MonoBehaviour
{
   
    public GameObject pictureObject;
    public void off(){
        pictureObject.SetActive(false);
    }
    public void on(){
        pictureObject.SetActive(true);
    }
    
}
