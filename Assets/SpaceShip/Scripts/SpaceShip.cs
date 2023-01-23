using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceShip
{
    private SpaceShipInfo _spaceShipInfo;
    private SpaceShipView _spaceShipView;
    private BaseSpaceShipInput _spaceShipInputHandler;
    private GameContainer _gameContainer;
    private SpaceShipEngine _spaceShipEngine;

    public SpaceShip(GameContainer gameContainer, SpaceShipInfo spaceShipInfo, SpaceShipView spaceShipView, BaseSpaceShipInput spaceShipInputHandler, SpaceShipEngine spaceShipEngine)
    {
        _gameContainer = gameContainer;
        _spaceShipInfo = spaceShipInfo;
        _spaceShipView = spaceShipView;
        _spaceShipInputHandler = spaceShipInputHandler;
        _spaceShipInputHandler.Enable();
    }

    private void ActivateEngine(float speedModifier)
    {
        Debug.LogError("SpaceShip ActivateEngine");
    }

    private void Rotate(float speedModifier)
    {
        Debug.LogError("SpaceShip Rotate");
    }

    private void ShootFirstWeapon()
    {
        Debug.LogError("SpaceShip ShootFirstWeapon");
    }

    private void ShootSecondWeapon()
    {
        Debug.LogError("SpaceShip ShootSecondWeapon");
    }
}
