using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyMove : IUpdate
{
    public abstract void Update(float delta);
}