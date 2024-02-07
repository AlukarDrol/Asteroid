using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private EnemyView _enemyView;
    private BaseEnemyMove _baseEnemyMove;

    public Enemy(EnemyView enemyView, BaseEnemyMove baseEnemyMove)
    {
        _enemyView = enemyView;
        _baseEnemyMove = baseEnemyMove;
    }
}
