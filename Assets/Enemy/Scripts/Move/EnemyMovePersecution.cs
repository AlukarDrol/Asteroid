using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovePersecution : BaseEnemyMove
{
    private EnemyInfo _enemtInfo;
    private EnemyView _enemyView;
    private Transform _target;

    public EnemyMovePersecution(EnemyInfo enemyInfo, EnemyView enemyView, Transform target)
    {
        _enemtInfo = enemyInfo;
        _enemyView = enemyView;
        _target = target;
    }

    public override void Update(float delta)
    {
        Vector3 direction = (_target.position - _enemyView.transform.position).normalized;
        _enemyView.transform.position += direction * _enemtInfo.Speed * delta;
    }
}
