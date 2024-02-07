using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondWeaponShootInputSystem : BaseWeaponShootInputSystem
{
    BaseSpaceShipInput _baseSpaceShipInput;
    public SecondWeaponShootInputSystem(BaseSpaceShipInput baseSpaceShipInput)
    {
        _baseSpaceShipInput = baseSpaceShipInput;
        _baseSpaceShipInput.OnShootSecondWeapon += Shoot;
    }

    public override void Enable()
    {
        _baseSpaceShipInput.OnShootSecondWeapon += Shoot;
    }

    public override void Disable()
    {
        _baseSpaceShipInput.OnShootSecondWeapon -= Shoot;
    }
}
