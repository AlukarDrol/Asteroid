using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBulletMoveSystem : IUpdate
{
    public abstract void Update(float delta);
}
