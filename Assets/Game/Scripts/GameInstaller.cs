using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstaller
{
    private SpaceShipGenerator _spaceShipGenerator;

    public void Install(GameContainer gameContainer, GameSettingsSO gameSettingsSO)
    {
        _spaceShipGenerator = new SpaceShipGenerator();
        _spaceShipGenerator.CreateSpaceShip(gameContainer, gameSettingsSO);
    }
}
