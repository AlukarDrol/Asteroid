using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDisable
{
    private readonly List<IDisable> _disables = new List<IDisable>();
    public void DisableGame()
    {
        foreach (var element in _disables)
        {
            element.Disable();
        }
    }

    public void Add(IDisable disableObject)
    {
        _disables.Add(disableObject);
    }

    public void Remove(IDisable disableObject)
    {
        _disables.Remove(disableObject);
    }
}
