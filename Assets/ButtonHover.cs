using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform parentRectTransform;
    private Vector3 originalScale;
    public float hoverScale = 1.1f;

    private void Start()
    {
        parentRectTransform = GetComponent<RectTransform>();
        originalScale = parentRectTransform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Scale up the parent GameObject
        parentRectTransform.localScale = originalScale * hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Reset the parent GameObject to its original scale
        parentRectTransform.localScale = originalScale;
    }
}
