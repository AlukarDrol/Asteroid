using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer : MonoBehaviour
{
    [SerializeField] private GameUpdates _gameUpdates;
    public GameUpdates GameUpdates => _gameUpdates;

    [SerializeField] private GameUIContainer _gameUIContainer;
    public GameUIContainer GameUIContainer => _gameUIContainer;

    private void Awake()
    {
        Game game = new Game(this);
    }
}
