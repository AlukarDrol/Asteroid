using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletGenerator
{
    public static void CreateBullet(GameContainer gameContainer,BulletInfo bulletInfo, BulletView bulletView, BulletModel bulletModel)
    {
        bulletView.transform.position = bulletModel.ShootPoint.position;
        bulletView.transform.rotation = bulletModel.ShootPoint.rotation;
        BaseBulletMoveSystem baseBulletMoveSystem = BulletMoveFactory.Create(bulletInfo, bulletView);
        gameContainer.GameUpdates.Add(baseBulletMoveSystem);
        bulletView.gameObject.SetActive(true);
        Bullet bullet = new Bullet(baseBulletMoveSystem);
    }
}
