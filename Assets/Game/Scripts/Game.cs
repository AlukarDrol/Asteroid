using UnityEngine;
using System;

public class Game
{
    private static readonly  string GameSettingPath = "GameSettings";

    private readonly GameContainer _gameContainer;
    public GameContainer GameContainer => _gameContainer;

    private GameInstaller _gameInstaller;
    public GameInstaller GameInstaller => _gameInstaller;

    private GameSettingsSO _gameSettingsSO;
    private EnemySpawner _enemySpawner;
    private SpaceShip _spaceShip;
    public SpaceShip SpaceShip => _spaceShip;

    private GameEnable _gameEnable;
    public GameEnable GameEnable => _gameEnable;

    private GameDisable _gameDisable;
    public GameDisable GameDisable => _gameDisable;


    public Game(GameContainer gameContainer)
    {
        _gameContainer = gameContainer;

        _gameSettingsSO = Resources.Load<GameSettingsSO>(GameSettingPath);
        _gameInstaller = new GameInstaller();
        _gameEnable = new GameEnable();
        _gameDisable = new GameDisable();

        _gameInstaller.Install(this, _gameSettingsSO, out _spaceShip);
        _gameContainer.GameUIContainer.StartGameUIContainer.PlayButtonUI.OnClick += StartGame;


        _enemySpawner = new EnemySpawner(GameInstaller.EnemyGenerator, _gameSettingsSO.GameSettings.EnemySpawnerInfoSO);
        GameContainer.GameUpdates.Add(_enemySpawner);
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