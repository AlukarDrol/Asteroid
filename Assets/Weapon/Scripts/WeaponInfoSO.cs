using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponInfoSO", menuName = "ScriptableObjects/WeaponInfoSO", order = 1)]
public class WeaponInfoSO : ScriptableObject
{
    [SerializeField] private WeaponInfo _weaponInfo;
    public WeaponInfo WeaponInfo => _weaponInfo;
}
