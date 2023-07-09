using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBar : MonoBehaviour
{
    public RectTransform barTransform;
    public float totalTime = 10f;
    private float currentTime;

    private void Start()
    {
        currentTime = totalTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        // Calculate the scale of the bar based on the remaining time
        float scale = Mathf.Clamp01(currentTime / totalTime);
        barTransform.localScale = new Vector3(scale, 1f, 1f);

        if (currentTime <= 0f)
        {
            // Time is up, perform any necessary actions
            Debug.Log("Time's up!");
        }
    }
}
