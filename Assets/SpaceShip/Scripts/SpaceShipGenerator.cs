using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipGenerator
{
    private const string PATH_SHIP_RESORCE = "";

    public bool TryCreateSpaceShip(GameContainer gameContainer, GameSettingsSO gameSettingsSO, out SpaceShip spaceShip)
    {
        spaceShip = null;
        string spaceShipSettingName = gameSettingsSO.GameSettings.SpaceShipSettingsName;
        SpaceShipInfoSO spaceShipInfoSO = Resources.Load<SpaceShipInfoSO>(PATH_SHIP_RESORCE + spaceShipSettingName);

        if (spaceShipInfoSO == null)
        {
            Debug.LogError($"Настроек для корабля {spaceShipSettingName} не существует");
            return false;
        }
        string spaceShipInfoName = spaceShipInfoSO.SpaceShipInfo.Name;
        SpaceShipView resources = Resources.Load<SpaceShipView>(spaceShipInfoName);
        if(resources == null)
        {
            Debug.LogError($"Модели для корабля {spaceShipInfoName} не существует");
            return false;
        }

        SpaceShipView spaceShipView = MonoBehaviour.Instantiate<SpaceShipView>(resources);

        SpaceShipModel spaceShipModel = new SpaceShipModel();

        SpaceShipInputSystemHandler spaceShipInputHandler = new SpaceShipInputSystemHandler();
        SpaceShipEngine spaceShipEngine = new SpaceShipEngine(gameContainer, spaceShipModel, spaceShipInputHandler);
        SpaceShipMoveSystem spaceShipMove = new SpaceShipMoveSystem(spaceShipInfoSO.SpaceShipInfo, spaceShipModel, spaceShipView);
        SpaceShipInputAngle spaceShipInputAngle = new SpaceShipInputAngle(spaceShipModel, spaceShipInputHandler);

        gameContainer.GameUpdates.Add(spaceShipMove);
        gameContainer.GameUpdates.Add(spaceShipEngine);

        List<Weapon> weapons = new List<Weapon>();
        Weapon firstWeapon = WeaponGenerator.CreateWeapon(gameContainer, spaceShipInfoSO.SpaceShipInfo.FirstWeaponInfo.WeaponInfo, spaceShipView.WeaponPivot, new FirstWeaponShootInputSystem(spaceShipInputHandler));
        weapons.Add(firstWeapon);
        Weapon secondWeapon = WeaponGenerator.CreateWeapon(gameContainer, spaceShipInfoSO.SpaceShipInfo.SecondWeaponInfo.WeaponInfo, spaceShipView.WeaponPivot, new SecondWeaponShootInputSystem(spaceShipInputHandler));
        weapons.Add(secondWeapon);
        spaceShip = new SpaceShip(spaceShipInfoSO.SpaceShipInfo, spaceShipView, spaceShipEngine, weapons);

        return true;
    }
}
