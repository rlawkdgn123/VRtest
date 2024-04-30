using Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftControllerAction : MonoBehaviour, XRIDefaultInputActions.IXRILeftHandActions
{
    private XRIDefaultInputActions controls;
    [SerializeField] private Player player;

    private void OnEnable() {
        if(controls == null)
        {
            controls = new XRIDefaultInputActions();
            controls.XRILeftHand.SetCallbacks(this);
        }
        controls.XRILeftHand.Enable();
    }
    public void OnPrimaryButtonPress(InputAction.CallbackContext context) {
        if (context.performed)
        {
            Debug.Log("Left Controller : Primary Button Press!");
        }
        //throw new System.NotImplementedException();
    }
    public void OnRotation(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
    public void OnSeconddaryButtonPress(InputAction.CallbackContext context) {
        if (!context.performed)
        {
            Debug.Log("Left Controller : secondary Button Press!");
        }
        //throw new System.NotImplementedException();
    }

    public void OnPosition(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnIsTracked(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnTrackingState(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnHapticDevice(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnAimPosition(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnAimRotation(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnAimFlags(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnPinchPosition(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnPokePosition(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnPokeRotation(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnGripPosition(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnGripRotation(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnPrimaryButtonpress(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnSecondaryButtonPress(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }
}
