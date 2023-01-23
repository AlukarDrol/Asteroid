using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipEngine : IUpdate
{
    private GameContainer _gameContainer;
    private BaseSpaceShipInput _baseSpaceShipInput;

    private float _speedMultipler = 0.0f;
    public float SpeedModifier => _speedMultipler;
    public SpaceShipEngine(GameContainer gameContainer, BaseSpaceShipInput baseSpaceShipInput)
    {
        _gameContainer = gameContainer;
        _baseSpaceShipInput = baseSpaceShipInput;
        _gameContainer.GameUpdates.Add(this);
        _baseSpaceShipInput.OnActivateEngine += ActivateEngine;
    }

    public void ActivateEngine(float speedMultipler)
    {
        _speedMultipler = speedMultipler;
    }

    public void Update(float delta)
    {
        
    }
}
