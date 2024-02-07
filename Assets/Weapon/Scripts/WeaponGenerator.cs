using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WeaponGenerator
{
    public static Weapon CreateWeapon(GameContainer gameContainer, WeaponInfo weaponInfo, Transform shootPoint, BaseWeaponShootInputSystem baseSpaceShipInput)
    {
        BulletModel bulletModel = new BulletModel();
        bulletModel.ShootPoint = shootPoint;

        BulletView example = Resources.Load<BulletView>(weaponInfo.BulletInfo.Name);
        BulletShot weaponShootBullet = new BulletShot(gameContainer, weaponInfo.BulletInfo, example, bulletModel, baseSpaceShipInput);
        
        Weapon weapon = new Weapon(weaponInfo, weaponShootBullet);
        return weapon;
    }
}
