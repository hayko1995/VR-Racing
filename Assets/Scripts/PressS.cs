﻿using WindowsInput.Native;
using WindowsInput;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SimpleInputNamespace
{

    public class PressS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        public float value = 1f;
        InputSimulator sim = new InputSimulator();
        public SimpleInput.AxisInput axis = new SimpleInput.AxisInput();



        private void Awake()
        {
            Graphic graphic = GetComponent<Graphic>();
            if (graphic != null)
                graphic.raycastTarget = true;
        }
        private void OnEnable()
        {
            axis.StartTracking();
        }

        private void OnDisable()
        {
            axis.StopTracking();
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            axis.value = value;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            axis.value = 0f;
        }
        public void pressS()
        {
            axis.value = value;

            // sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
        }
        public void reliseS()
        {
            axis.value = 0f;

            // sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
        }


    }
}