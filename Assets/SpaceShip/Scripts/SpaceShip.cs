using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceShip
{
    private SpaceShipInfo _spaceShipInfo;
    private SpaceShipView _spaceShipView;
    public SpaceShipView SpaceShipView => _spaceShipView;

    private SpaceShipEngine _spaceShipEngine;
    private List<Weapon> _weapons;
    public SpaceShip(SpaceShipInfo spaceShipInfo, SpaceShipView spaceShipView, SpaceShipEngine spaceShipEngine, List<Weapon> weapon)
    {
        _spaceShipInfo = spaceShipInfo;
        _spaceShipView = spaceShipView;
        _spaceShipEngine = spaceShipEngine;
        _weapons = weapon;
    }
}
