using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IPointerDownHandler,IPointerUpHandler, IDragHandler
{
    RectTransform rect;
    Vector2 touch = Vector2.zero;

    public RectTransform handle;
    float widthHalf;
    void Start()
    {
        rect = GetComponent<RectTransform>();
        widthHalf = rect.sizeDelta.x * 0.5f;
    }
    public void OnDrag(PointerEventData eventData)
    {
        touch = eventData.position - (rect.anchoredPosition)/ widthHalf;
        if (touch.magnitude > 1)
            touch = touch.normalized;
        handle.anchoredPosition = touch * widthHalf;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
