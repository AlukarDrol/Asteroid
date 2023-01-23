using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game
{
    private const string GAME_SETTINGS_PATH = "GameSettings";

    private GameContainer _gameContainer;
    private GameInstaller _gameInstaller;
    private GameSettingsSO _gameSettingsSO;


    public Game(GameContainer gameContainer)
    {
        _gameContainer = gameContainer;

        _gameSettingsSO = Resources.Load<GameSettingsSO>(GAME_SETTINGS_PATH);
        _gameInstaller = new GameInstaller();

        _gameInstaller.Install(_gameContainer, _gameSettingsSO);
        _gameContainer.GameUIContainer.StartGameUIContainer.PlayButtonUI.OnClick += StartGame;
    }

    public event Action OnStartGame;
    public event Action OnEndGame;
    private void StartGame()
    {
        OnStartGame?.Invoke();
        _gameContainer.GameUIContainer.ShowWindowByType(WindowType.SpaceShipUI);

    }

    private void EndGame()
    {
        OnEndGame?.Invoke();
        _gameContainer.GameUIContainer.ShowWindowByType(WindowType.StartGame);
    }
}