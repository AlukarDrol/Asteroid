using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot
{
    private BulletInfo _bulletInfo;
    private MonoPool<BulletView> _poolBulletView;
    private BaseWeaponShootInputSystem _weaponShootInputSystem;
    private BulletModel _bulletModel;
    private GameContainer _gameContainer;
    public BulletShot(GameContainer gameContainer, BulletInfo bulletInfo, BulletView bulletView, BulletModel bulletModel, BaseWeaponShootInputSystem weaponShootInputSystem)
    {
        _bulletInfo = bulletInfo;
        GameObject poolBullet = new GameObject(bulletInfo.Name);
        _poolBulletView = new MonoPool<BulletView>(bulletView, poolBullet.transform);
        _gameContainer = gameContainer;
        _weaponShootInputSystem = weaponShootInputSystem;
        _bulletModel = bulletModel;
        _weaponShootInputSystem.OnShoot += Shoot;
    }

    public void Shoot()
    {
        BulletGenerator.CreateBullet(_gameContainer, _bulletInfo, _poolBulletView.Get(), _bulletModel);
    }
}
