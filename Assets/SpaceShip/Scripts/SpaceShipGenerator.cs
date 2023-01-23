using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipGenerator
{
    private const string PATH_SHIP_RESORCE = "";

    public void CreateSpaceShip(GameContainer gameContainer, GameSettingsSO gameSettingsSO)
    {
        string spaceShipSettingName = gameSettingsSO.GameSettings.SpaceShipSettingsName;
        SpaceShipInfoSO spaceShipInfoSO = Resources.Load<SpaceShipInfoSO>(PATH_SHIP_RESORCE + spaceShipSettingName);

        if (spaceShipInfoSO == null)
        {
            Debug.LogError($"Настроек для корабля {spaceShipSettingName} не существует");
            return;
        }
        string spaceShipInfoName = spaceShipInfoSO.SpaceShipInfo.Name;
        SpaceShipView resources = Resources.Load<SpaceShipView>(spaceShipInfoName);
        if(resources == null)
        {
            Debug.LogError($"Модели для корабля {spaceShipInfoName} не существует");
            return;
        }

        SpaceShipView spaceShipView = MonoBehaviour.Instantiate<SpaceShipView>(resources);
        SpaceShipInputSystemHandler spaceShipInputHandler = new SpaceShipInputSystemHandler();
        SpaceShipEngine spaceShipEngine = new SpaceShipEngine(gameContainer, spaceShipInputHandler);
        SpaceShipMove spaceShipMove = new SpaceShipMove(gameContainer, spaceShipEngine, spaceShipView, spaceShipInputHandler);
        gameContainer.GameUpdates.Add(spaceShipMove);
        gameContainer.GameUpdates.Add(spaceShipEngine);

        SpaceShip spaceShip = new SpaceShip(gameContainer, spaceShipInfoSO.SpaceShipInfo, spaceShipView, spaceShipInputHandler, spaceShipEngine);
    }
}
