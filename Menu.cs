﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Menu : MonoBehaviour
{
    public VRTK_ControllerEvents controllerEvents;
    public GameObject menu;
    bool menuState = false;

    void OnEnable()
    {
        controllerEvents.ButtonTwoPressed += ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }
    void OnDisable()
    {
        controllerEvents.ButtonTwoPressed -= ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }

    private void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        menuState = !menuState;
        menu.SetActive(menuState);
    }

    private void ControllerEvents_ButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
    {
       
    }
}
