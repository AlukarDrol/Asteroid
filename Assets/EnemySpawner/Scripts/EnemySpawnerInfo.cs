using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemySpawnerInfo
{
    public List<EnemySpawnInfo> EnemySpawnInfos = new List<EnemySpawnInfo>();
    [SerializeField] private float _timeNextSpawn = 0.0f;
    public float TimeNextSpawn => _timeNextSpawn;
}
