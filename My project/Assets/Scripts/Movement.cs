using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    bool isPressed= false;
    public float Speed;
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(0, Speed, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
