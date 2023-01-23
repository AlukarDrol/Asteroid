using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WindowType { None, StartGame, SpaceShipUI}
public class GameUIContainer : MonoBehaviour
{
    [SerializeField] private StartGameUIContainer _startGameUIContainer;
    public StartGameUIContainer StartGameUIContainer => _startGameUIContainer;

    [SerializeField] private SpaceShipUIContainer _spaceShipUIContainer;
    public SpaceShipUIContainer SpaceShipUIContainer => _spaceShipUIContainer;

    public void ShowWindowByType(WindowType windowType)
    {
        _startGameUIContainer.gameObject.SetActive(false);
        _spaceShipUIContainer.gameObject.SetActive(false);
        switch (windowType)
        {
            case WindowType.StartGame:
                _startGameUIContainer.gameObject.SetActive(true);
                break;
            case WindowType.SpaceShipUI:
                _spaceShipUIContainer.gameObject.SetActive(true);
                break;
        }
    }
}
