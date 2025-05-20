using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{
    //estado
    [SerializeField] private XRRayInteractor XRRayInteractor_Grab;
    [SerializeField] private XRRayInteractor XRRayInteractor_Teleport;

    [SerializeField] private InputActionReference _JoyStick_Sector_Norte;

    private void Awake()
    {
        XRRayInteractor_Teleport.enabled = false;

    }

    private void OnEnable()
    {
        _JoyStick_Sector_Norte.action.performed += PalancaArribaPresionada;
        _JoyStick_Sector_Norte.action.canceled += PalancaArribaLiberada;

    }

    private void OnDisable()
    {
        _JoyStick_Sector_Norte.action.performed -= PalancaArribaPresionada;
        _JoyStick_Sector_Norte.action.canceled -= PalancaArribaLiberada;
    }

    private void PalancaArribaPresionada(InputAction.CallbackContext context)
    {
        XRRayInteractor_Grab.enabled = false;
        XRRayInteractor_Teleport.enabled = true;
        print("Palanca Arrriba Presionada");


    }

    private void PalancaArribaLiberada(InputAction.CallbackContext context) => Invoke("PalancaArribaLiberada_Invoke", 0.001f);

    private void PalancaArribaLiberada_Invoke()
    {
        XRRayInteractor_Grab.enabled = true;
        XRRayInteractor_Teleport.enabled = false;
        print("Palanca Arrriba Liberada");

    }
}