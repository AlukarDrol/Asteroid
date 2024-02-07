using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseWeaponShootInputSystem
{

    public abstract void Enable();

    public abstract void Disable();

    public event Action OnShoot;
    protected void Shoot()
    {
        OnShoot?.Invoke();
    }
}
