using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemyInfo
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private float _speed;
    public float Speed => _speed;

    [SerializeField] private EnemyMoveType _enemyMoveType;
    public EnemyMoveType EnemyMoveType => _enemyMoveType;
}
