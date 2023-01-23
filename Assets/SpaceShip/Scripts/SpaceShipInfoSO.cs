using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpaceShipInfo", menuName = "ScriptableObjects/SpaceShipInfo", order = 1)]
public class SpaceShipInfoSO : ScriptableObject
{
    [SerializeField] private SpaceShipInfo _spaceShipInfo;
    public SpaceShipInfo SpaceShipInfo => _spaceShipInfo;
}
