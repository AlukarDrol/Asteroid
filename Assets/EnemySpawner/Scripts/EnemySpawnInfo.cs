using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct EnemySpawnInfo
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private float _weigth;
    public float Weigth => _weigth;
}
