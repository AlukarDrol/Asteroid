using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolView
{
    private Dictionary<string, MonoPool<EnemyView>> _enemyPools = new Dictionary<string, MonoPool<EnemyView>>();

    public EnemyView Get(string nameEnemy)
    {
        if(!_enemyPools.ContainsKey(nameEnemy))
        {
            _enemyPools.Add(nameEnemy, CreatePoolEnemy(nameEnemy));
        }
        return _enemyPools[nameEnemy].Get();
    }

    private MonoPool<EnemyView> CreatePoolEnemy(string nameEnemy)
    {
        EnemyView enemyView = Resources.Load<EnemyView>(nameEnemy);
        GameObject enemyPool = new GameObject(nameEnemy); 
        return new MonoPool<EnemyView>(enemyView, enemyPool.transform);
    }
}
