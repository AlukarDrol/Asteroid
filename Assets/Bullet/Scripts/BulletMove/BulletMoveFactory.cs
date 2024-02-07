using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletMoveFactory
{
    public static BaseBulletMoveSystem Create(BulletInfo bulletInfo, BulletView bulletView)
    {
        switch (bulletInfo.BulletMoveType)
        {
            case BulletMoveType.Forward:
                return new ForwardBulletMoveSystem(bulletInfo, bulletView);
            case BulletMoveType.Stay:
                return new StayBulletMoveSystem();
            default:
                return new StayBulletMoveSystem();
        }
    }
}
