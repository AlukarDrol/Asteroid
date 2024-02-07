using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveFactory
{
    private Game _game;
    public EnemyMoveFactory(Game game)
    {
        _game = game;
    }

    public BaseEnemyMove Create(EnemyInfo enemyInfo, EnemyView enemyView)
    {
        switch (enemyInfo.EnemyMoveType)
        {
            case EnemyMoveType.OneDirection:
                return new EnemyMoveOneDirection(enemyInfo, enemyView);
            case EnemyMoveType.Persecution:
                return new EnemyMovePersecution(enemyInfo, enemyView, _game.SpaceShip.SpaceShipView.transform);
            default:
                return new EnemyMoveOneDirection(enemyInfo, enemyView);

        }
    }
}
