using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Super : MonoBehaviour
{
   
    public GameObject pictureObject;
    public void off(){
        pictureObject.SetActive(false);
    }
    public void on(){
        pictureObject.SetActive(true);
    }
    
}
