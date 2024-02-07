using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBulletMoveSystem : BaseBulletMoveSystem
{
    private BulletInfo _bulletInfo;
    private BulletView _bulletView;

    public ForwardBulletMoveSystem(BulletInfo bulletInfo, BulletView bulletView)
    {
        _bulletInfo = bulletInfo;
        _bulletView = bulletView;
    }

    public override void Update(float delta)
    {
        _bulletView.transform.position += _bulletView.transform.up * _bulletInfo.Speed * delta;
    }
}