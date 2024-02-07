using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipInputAngle
{
    private readonly SpaceShipModel _spaceShipModel;
    private readonly BaseSpaceShipInput _baseSpaceShipInput;

    public SpaceShipInputAngle(SpaceShipModel spaceShipModel, BaseSpaceShipInput baseSpaceShipInput)
    {
        _spaceShipModel = spaceShipModel;
        _baseSpaceShipInput = baseSpaceShipInput;
        _baseSpaceShipInput.OnChangeAngle += ChangeAngle;
    }

    public void Enable()
    {
        _baseSpaceShipInput.OnChangeAngle += ChangeAngle;
    }

    public void Disable()
    {
        _baseSpaceShipInput.OnChangeAngle -= ChangeAngle;
    }

    private void ChangeAngle(float angle)
    {
        _spaceShipModel.Angle = angle;
    }
}
