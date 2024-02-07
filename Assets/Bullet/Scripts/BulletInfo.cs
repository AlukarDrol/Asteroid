using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletInfo
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private float _speed;
    public float Speed => _speed;

    [SerializeField] private float _lifeTime;
    public float LifeTime => _lifeTime;

    [SerializeField] private BulletMoveType _bulletMoveType;
    public BulletMoveType BulletMoveType => _bulletMoveType;
}
