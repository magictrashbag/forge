using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterDragHandler : MonoBehaviour 
{
    bool isHeld = false;
    bool isDragging = false;
    Vector3 originalPosition;
    Button test;

    private void Start()
    {
        originalPosition = transform.position;
    }

    public void OnDown()
    {
        Debug.Log("OnDown");
        isHeld = true;
    }

    public void OnDrag()
    {
        Debug.Log("OnDrag");
        isDragging = true;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnUp()
    {
        Debug.Log("OnUp");
        transform.position = originalPosition;
        isHeld = false;
        bool isDragging = false;
    }
}
