using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : IUpdate
{
    private SpaceShipEngine _spaceShipEngine;
    private SpaceShipView _spaceShipView;
    private BaseSpaceShipInput _baseSpaceShipInput;
    private float _angle = 0.0f;
    public SpaceShipMove(GameContainer gameContainer, SpaceShipEngine spaceShipEngine, SpaceShipView spaceShipView, BaseSpaceShipInput baseSpaceShipInput)
    {
        _spaceShipEngine = spaceShipEngine;
        _spaceShipView = spaceShipView;
        _baseSpaceShipInput = baseSpaceShipInput;
        _baseSpaceShipInput.OnChangeAngle += ChangeAngle;
    }

    public void Update(float delta)
    {
        Move(delta);
        Rotate(delta);
    }

    private void Move(float delta)
    {
        float speed = _spaceShipEngine.SpeedModifier * delta;
        _spaceShipView.transform.position += _spaceShipView.transform.up * (_spaceShipEngine.SpeedModifier * delta);
    }

    private void ChangeAngle(float angle)
    {
        _angle = angle;
    }

    private void Rotate(float delta)
    {
        _spaceShipView.transform.Rotate(Vector3.forward, _angle * delta);
    }
}
