using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipView : MonoBehaviour
{
    [SerializeField] private Transform _weaponPivot;
    public Transform WeaponPivot => _weaponPivot;
}
