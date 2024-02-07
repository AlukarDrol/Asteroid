using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWeaponShootInputSystem : BaseWeaponShootInputSystem
{
    BaseSpaceShipInput _baseSpaceShipInput;
    public FirstWeaponShootInputSystem(BaseSpaceShipInput baseSpaceShipInput)
    {
        _baseSpaceShipInput = baseSpaceShipInput;
        _baseSpaceShipInput.OnShootFirstWeapon += Shoot;
    }

    public override void Enable()
    {
        _baseSpaceShipInput.OnShootFirstWeapon += Shoot;
    }

    public override void Disable()
    {
        _baseSpaceShipInput.OnShootFirstWeapon -= Shoot;
    }
}
