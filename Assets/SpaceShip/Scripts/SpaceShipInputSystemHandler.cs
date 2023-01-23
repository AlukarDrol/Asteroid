using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceShipInputSystemHandler : BaseSpaceShipInput
{
    [SerializeField] private float _speed = 10.0f;
    private SpaceShipInput _input;
    public SpaceShipInputSystemHandler()
    {
        _input = new SpaceShipInput();

        _input.SpaceShip.Rotate.performed += ChangeAngle;
        _input.SpaceShip.Rotate.canceled += ChangeAngle;
        _input.SpaceShip.ActivateEngine.performed += ActivateEngine;
        _input.SpaceShip.ActivateEngine.canceled += ActivateEngine;
        _input.SpaceShip.ShootFirstWeapon.performed += StartShootFirstWeapon;
        _input.SpaceShip.ShootFirstWeapon.canceled += EndShootFirstWeapon;
        _input.SpaceShip.ShootSecondWeapon.performed += StartShootSecondWeapon;
        _input.SpaceShip.ShootSecondWeapon.canceled += EndShootSecondWeapon;
    }

    public override void Enable()
    {
        _input.Enable();
    }

    public override void Disable()
    {
        _input.Disable();
    }

    private void ChangeAngle(InputAction.CallbackContext callbackContext)
    {
        ChangeAngle(callbackContext.ReadValue<float>());
    }

    private void ActivateEngine(InputAction.CallbackContext callbackContext)
    {
        ActivateEngine(callbackContext.ReadValue<float>());
    }

    private void StartShootFirstWeapon(InputAction.CallbackContext callbackContext)
    {
        StartShootFirstWeapon();
    }

    private void EndShootFirstWeapon(InputAction.CallbackContext callbackContext)
    {
        EndShootFirstWeapon();
    }

    private void StartShootSecondWeapon(InputAction.CallbackContext callbackContext)
    {
        StartShootSecondWeapon();
    }

    private void EndShootSecondWeapon(InputAction.CallbackContext callbackContext)
    {
        EndShootSecondWeapon();
    }
}
