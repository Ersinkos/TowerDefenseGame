using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standartTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandartTurret()
    {
        Debug.Log("Standart Turret Selected");
        buildManager.SelectTurretToBuild(standartTurret);
    }
    public void SelectMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SelectTurretToBuild(missileTurret);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
