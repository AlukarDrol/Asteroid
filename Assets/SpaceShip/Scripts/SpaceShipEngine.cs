using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipEngine : IUpdate
{
    private GameContainer _gameContainer;
    private BaseSpaceShipInput _baseSpaceShipInput;
    private SpaceShipModel _spaceShipModel;

    public SpaceShipEngine(GameContainer gameContainer, SpaceShipModel spaceShipModel, BaseSpaceShipInput baseSpaceShipInput)
    {
        _gameContainer = gameContainer;
        _baseSpaceShipInput = baseSpaceShipInput;
        _spaceShipModel = spaceShipModel;
        _baseSpaceShipInput.OnActivateEngine += ActivateEngine;
    }

    public void Enable()
    {
        _baseSpaceShipInput.OnActivateEngine += ActivateEngine;
    }

    public void Disable()
    {
        _baseSpaceShipInput.OnActivateEngine -= ActivateEngine;
    }

    public void ActivateEngine(float speedMultipler)
    {
        _spaceShipModel.SpeedModifier = speedMultipler;
    }

    public void Update(float delta)
    {
        
    }
}
