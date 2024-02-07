using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet
{
    public Bullet(BaseBulletMoveSystem baseBulletMove)
    {
        _baseBulletMove = baseBulletMove;
    }
    private BaseBulletMoveSystem _baseBulletMove;
}
