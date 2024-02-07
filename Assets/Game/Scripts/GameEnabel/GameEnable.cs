using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnable
{
    private readonly List<IEnable> _enables = new List<IEnable>();
    private bool _isEnable = false;

    public void EnableGame()
    {
        foreach (var element in _enables)
        {
            element.Enable();
        }
    }

    public void Add(IEnable enableObject)
    {
        _enables.Add(enableObject);
        if (_isEnable)
        {
            enableObject.Enable();
        }
    }

    public void Remove(IEnable enableObject)
    {
        _enables.Remove(enableObject);
    }
}
