using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    private bool dragging = false;
    private Transform position;

    void Start()
    {
        position = GetComponent<Transform>();
    }

    void OnMouseDown()
    {
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPoint.z = 0;
            position.position = worldPoint;
        }
    }
}
