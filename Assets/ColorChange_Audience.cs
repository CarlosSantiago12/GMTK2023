using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange_Audience : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color[] colors = new Color[3];
    public float changeInterval = 5f;

    public CS_Mega CS_Mega;
    public CS_Ultra CS_Ultra;
    public CS_Super CS_Super;
    public Bool_Manager Bools;
    private int currentIndex = 0;

    private void Start()
    {
        
        StartCoroutine(ChangeColorCoroutine());
        
    }

    private IEnumerator ChangeColorCoroutine()
    {
        while (true)
        {
            Bools.Super = false;
            Bools.Mega = false;
            Bools.Ultra = false;
            // Change the sprite color
            spriteRenderer.color = colors[currentIndex];

            // Increment the index to move to the next color
            currentIndex = (currentIndex + 1) % colors.Length;
            
            if(currentIndex == 1){ //RED = SUPER
                Bools.Super = true;
                CS_Mega.off();
                CS_Ultra.off();
                CS_Super.on();
            } 
            else if(currentIndex == 2){ //BLUE = Mega
                Bools.Mega = true;
                CS_Mega.on();
                CS_Ultra.off();
                CS_Super.off();
            }
            else { //GREEN = Ultra
                Bools.Ultra = true;
                CS_Mega.off();
                CS_Ultra.on();
                CS_Super.off();
            }
            
            
            

            yield return new WaitForSeconds(changeInterval);
            
            //Bools.Print_Bools();
        }
    }
}
