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
        _input.SpaceShip.ShootFirstWeapon.performed += ShootFirstWeapon;
        _input.SpaceShip.ShootSecondWeapon.performed += ShootSecondWeapon;
        _input.Enable();
    }

    public override void Enable()
    {
        _input.Enable();
        _input.SpaceShip.Rotate.performed += ChangeAngle;
        _input.SpaceShip.Rotate.canceled += ChangeAngle;
        _input.SpaceShip.ActivateEngine.performed += ActivateEngine;
        _input.SpaceShip.ActivateEngine.canceled += ActivateEngine;
        _input.SpaceShip.ShootFirstWeapon.performed += ShootFirstWeapon;
        _input.SpaceShip.ShootSecondWeapon.performed += ShootSecondWeapon;
    }

    public override void Disable()
    {
        _input.Disable();
        _input.SpaceShip.Rotate.performed -= ChangeAngle;
        _input.SpaceShip.Rotate.canceled -= ChangeAngle;
        _input.SpaceShip.ActivateEngine.performed -= ActivateEngine;
        _input.SpaceShip.ActivateEngine.canceled -= ActivateEngine;
        _input.SpaceShip.ShootFirstWeapon.performed -= ShootFirstWeapon;
        _input.SpaceShip.ShootSecondWeapon.performed -= ShootSecondWeapon;
    }

    private void ChangeAngle(InputAction.CallbackContext callbackContext)
    {
        ChangeAngle(callbackContext.ReadValue<float>());
    }

    private void ActivateEngine(InputAction.CallbackContext callbackContext)
    {
        ActivateEngine(callbackContext.ReadValue<float>());
    }

    private void ShootFirstWeapon(InputAction.CallbackContext callbackContext)
    {
        ShootFirstWeapon();
    }

    private void ShootSecondWeapon(InputAction.CallbackContext callbackContext)
    {
        ShootFirstWeapon();
    }
}
