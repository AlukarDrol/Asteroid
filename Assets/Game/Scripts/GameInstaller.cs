using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstaller
{
    private SpaceShipGenerator _spaceShipGenerator;
    private EnemyMoveFactory _enemyMoveFactory;

    private EnemyGenerator _enemyGenerator;
    public EnemyGenerator EnemyGenerator => _enemyGenerator;

    public void Install(Game game, GameSettingsSO gameSettingsSO, out SpaceShip spaceShip)
    {
        spaceShip = null;
        _spaceShipGenerator = new SpaceShipGenerator();
        _spaceShipGenerator.TryCreateSpaceShip(game.GameContainer, gameSettingsSO, out spaceShip);
        _enemyMoveFactory = new EnemyMoveFactory(game);
        _enemyGenerator = new EnemyGenerator(game.GameContainer, _enemyMoveFactory);
    }
}