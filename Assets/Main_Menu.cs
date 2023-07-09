using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void howToPlay(){
        SceneManager.LoadScene(2);
    }
    public void End(){
        SceneManager.LoadScene(3);
    }
    // Update is called once per frame
   
}
