using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : IUpdate
{
    private float _currentTime = 0.0f;
    private EnemySpawnerInfo _enemySpawnerInfo;
    private EnemyGenerator _enemyGenerator;

    public EnemySpawner(EnemyGenerator enemyGenerator, EnemySpawnerInfoSO enemySpawnerInfoSO)
    {
        _enemyGenerator = enemyGenerator;
        _enemySpawnerInfo = enemySpawnerInfoSO.EnemySpawnerInfo;
    }

    public void SpawnRandomEnemy()
    {
        string enemyName = "";
        if(TryRandomizeEnemy(out enemyName))
        {
            EnemyInfoSO enemyInfoSO = Resources.Load<EnemyInfoSO>(enemyName);
            if (enemyInfoSO == null)
            {
                Debug.LogError($"Не существует EnemyInfoSO с именем {enemyName}");
                return;
            }

            _enemyGenerator.CreateEnemy(enemyInfoSO.EnemyInfo, Vector3.zero);
        }
    }

    public void Update(float delta)
    {
        _currentTime -= delta;
        if (_currentTime <= 0)
        {
            SpawnRandomEnemy();
            _currentTime = _enemySpawnerInfo.TimeNextSpawn;
        }
    }

    public bool TryRandomizeEnemy(out string name)
    {
        name = "";
        float summa = 0.0f;
        foreach (var element in _enemySpawnerInfo.EnemySpawnInfos)
        {
            summa += element.Weigth;
        }
        float random = Random.Range(0.0f, summa);
        float currentWeight = 0.0f;
        foreach (var element in _enemySpawnerInfo.EnemySpawnInfos)
        {
            currentWeight += element.Weigth;
            if (random <= currentWeight)
            {
                name = element.Name;
                return true;
            }
        }
        return false;
    }
}
