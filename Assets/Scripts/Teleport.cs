using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Camera maincamera; // Have to assign the main camera 
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Detects the mouse press
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Mathf.Abs(maincamera.transform.position.z);
            transform.position = maincamera.ScreenToWorldPoint(mousePos);
        }
    }
}