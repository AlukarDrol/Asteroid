using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoveSystem : IUpdate
{
    private SpaceShipModel _spaceShipModel;
    private SpaceShipView _spaceShipView;
    private SpaceShipInfo _spaceShipInfo;

    public SpaceShipMoveSystem(SpaceShipInfo spaceShipInfo, SpaceShipModel spaceShipModel, SpaceShipView spaceShipView)
    {
        _spaceShipModel = spaceShipModel;
        _spaceShipView = spaceShipView;
        _spaceShipInfo = spaceShipInfo;
    }

    public void Update(float delta)
    {
        Move(delta);
        Rotate(delta);
    }

    private void Move(float delta)
    {
        _spaceShipView.transform.position += _spaceShipView.transform.up * (_spaceShipModel.SpeedModifier * _spaceShipInfo.Speed * delta);
    }

    private void Rotate(float delta)
    {
        _spaceShipView.transform.Rotate(Vector3.forward, _spaceShipModel.Angle * _spaceShipInfo.TurningSpeed * delta);
    }
}
