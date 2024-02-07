using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInfoSO", menuName = "ScriptableObjects/EnemyInfoSO", order = 1)]
public class EnemyInfoSO : ScriptableObject
{
    [SerializeField] private EnemyInfo _enemyInfo;
    public EnemyInfo EnemyInfo => _enemyInfo;
}
