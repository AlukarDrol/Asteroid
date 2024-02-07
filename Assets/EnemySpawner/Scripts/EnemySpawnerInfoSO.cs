using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnerInfoSO", menuName = "ScriptableObjects/EnemySpawnerInfoSO", order = 1)]
public class EnemySpawnerInfoSO : ScriptableObject
{
    [SerializeField] private EnemySpawnerInfo _enemySpawnerInfo;
    public EnemySpawnerInfo EnemySpawnerInfo => _enemySpawnerInfo;
}
