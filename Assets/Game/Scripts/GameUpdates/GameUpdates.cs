using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdates : MonoBehaviour
{
    private List<IUpdate> _updates = new List<IUpdate>();
    private bool _isPaused = false;

    public void Add(IUpdate updateObject)
    {
        _updates.Add(updateObject);
    }

    public void Remove(IUpdate updateObject)
    {
        _updates.Remove(updateObject);
    }

    public void Play()
    {
        _isPaused = false;
    }

    public void Pause()
    {
        _isPaused = true;
    }

    private void Update()
    {
        if (_isPaused)
        {
            return;
        }

        foreach (var element in _updates)
        {
            element.Update(Time.deltaTime);
        }
    }
}
