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

    public event Action OnStartShootFirstWeapon;
    public event Action OnEndStartShootFirstWeapon;
    public event Action OnStartShootSecondWeapon;
    public event Action OnEndStartShootSecondWeapon;

    protected void ActivateEngine(float speed)
    {
        OnActivateEngine?.Invoke(speed);
    }

    protected void ChangeAngle(float speed)
    {
        OnChangeAngle?.Invoke(speed);
    }

    protected void StartShootFirstWeapon()
    {
        OnStartShootFirstWeapon?.Invoke();
    }

    protected void EndShootFirstWeapon()
    {
        OnEndStartShootFirstWeapon?.Invoke();
    }

    protected void StartShootSecondWeapon()
    {
        OnStartShootSecondWeapon?.Invoke();
    }

    protected void EndShootSecondWeapon()
    {
        OnEndStartShootSecondWeapon?.Invoke();
    }
}
