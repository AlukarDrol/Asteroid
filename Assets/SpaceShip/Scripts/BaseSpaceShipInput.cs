using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseSpaceShipInput
{
    public abstract void Enable();
    public abstract void Disable();

    public event Action<float> OnActivateEngine;
    public event Action<float> OnChangeAngle;

    public event Action OnShootFirstWeapon;
    public event Action OnShootSecondWeapon;
 

    protected void ActivateEngine(float speed)
    {
        OnActivateEngine?.Invoke(speed);
    }

    protected void ChangeAngle(float speed)
    {
        OnChangeAngle?.Invoke(speed);
    }

    protected void ShootFirstWeapon()
    {
        OnShootFirstWeapon?.Invoke();
    }

    protected void ShootSecondWeapon()
    {
        OnShootSecondWeapon?.Invoke();
    }
}
