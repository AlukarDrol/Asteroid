using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdates : MonoBehaviour
{
    private readonly List<IUpdate> _updates = new List<IUpdate>();
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

        for (int i =0; i < _updates.Count; i++)
        {
            _updates[i].Update(Time.deltaTime);
        }
    }
}
