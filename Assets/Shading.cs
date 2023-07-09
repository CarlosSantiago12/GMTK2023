using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shading : MonoBehaviour
{
    public GameObject pictureObject;
    // Start is called before the first frame update

    // Update is called once per frame
    public void offShade(){
        pictureObject.SetActive(false); // Hide the picture
    }
    public void onShade(){
        pictureObject.SetActive(true); // Hide the picture
    }
}
