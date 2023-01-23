using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSettings
{
    [SerializeField] private string _spaceShipSettingsName;
    public string SpaceShipSettingsName => _spaceShipSettingsName;
}
