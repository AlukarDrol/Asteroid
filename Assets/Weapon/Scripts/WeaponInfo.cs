using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponInfo
{
    [SerializeField] private BulletInfo _bulletInfo;
    public BulletInfo BulletInfo => _bulletInfo;
}
