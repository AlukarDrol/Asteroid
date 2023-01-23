using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
public class GameSettingsSO : ScriptableObject
{
    [SerializeField] private GameSettings _gameSettings;
    public GameSettings GameSettings => _gameSettings;
}
