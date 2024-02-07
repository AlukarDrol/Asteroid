using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator
{
    private float _spawnEnemyRange = 10.0f;
    private EnemyPoolView _enemyPoolView;
    private EnemyMoveFactory _enemyMoveFactory;
    private GameContainer _gameContainer;

    public EnemyGenerator(GameContainer gameContainer, EnemyMoveFactory enemyMoveFactory)
    {
        _enemyMoveFactory = enemyMoveFactory;
        _gameContainer = gameContainer;
        _enemyPoolView = _gameContainer.EnemyPoolView;
    }

    public void CreateEnemy(EnemyInfo enemyInfo, Vector3 position)
    {
        EnemyView enemyView = _enemyPoolView.Get(enemyInfo.Name);
        enemyView.transform.position = Random.insideUnitCircle * _spawnEnemyRange;
        enemyView.gameObject.SetActive(true);
        BaseEnemyMove enemyMove = _enemyMoveFactory.Create(enemyInfo, enemyView);
        _gameContainer.GameUpdates.Add(enemyMove);
        Enemy enemy = new Enemy(enemyView, enemyMove);
    }
}