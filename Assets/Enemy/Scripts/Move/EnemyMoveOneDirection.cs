using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMoveOneDirection : BaseEnemyMove
{
    private EnemyInfo _enemtInfo;
    private EnemyView _enemyView;
    private Vector3 _direction;

    public EnemyMoveOneDirection(EnemyInfo enemyInfo, EnemyView enemyView)
    {
        _enemtInfo = enemyInfo;
        _enemyView = enemyView;
        _direction = RandomDirection();
    }

    public override void Update(float delta)
    {
        _enemyView.transform.position += _direction * _enemtInfo.Speed * delta;
    }

    private Vector3 RandomDirection()
    {
        return Random.insideUnitCircle.normalized;
    }
}
