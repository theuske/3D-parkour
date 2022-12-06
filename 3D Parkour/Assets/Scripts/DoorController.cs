﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Button;
    public GameObject Door;
    public bool doorIsOpening;
    public Material startMaterial;
    public Material hoverMaterial;
    bool mouseOver = false;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 800);
            //if the bool is true open the door

        }
        if (Door.transform.position.y > 30f)
        {

            doorIsOpening = false;
            //if the y of the door is > than 7 we want to stop the door
        }
    }
    void OnMouseDown()
    { //THIS FUNCTION WILL DETECT THE MOUSE CLICK ON A COLLIDER,IN OUR CASE WILL DETECT THE CLICK ON THE BUTTON

        mouseOver = true;
        GetComponent<Renderer>().material = hoverMaterial;
        doorIsOpening = true;
        //if we click on the button door we must start to open
    }
    private void OnMouseExit()

    {
        mouseOver = false;
        GetComponent<Renderer>().material = startMaterial;
    }

}