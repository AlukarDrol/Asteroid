using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private WeaponInfo _weaponInfo;
    private BulletShot _weaponShootBullet;

    public Weapon(WeaponInfo weaponInfo, BulletShot weaponShootBullet)
    {
        _weaponInfo = weaponInfo;
        _weaponShootBullet = weaponShootBullet;
    }
}
