using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpaceShipInfo
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private float _speed;
    public float Speed => _speed;

    [SerializeField] private float _maxSpeed;
    public float MaxSpeed => _maxSpeed;

    [SerializeField] private float _turningSpeed;
    public float TurningSpeed => _turningSpeed;
}