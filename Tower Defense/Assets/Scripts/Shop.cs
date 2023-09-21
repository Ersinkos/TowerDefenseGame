using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandartTurret()
    {
        Debug.Log("Standart Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }
    public void PurchaseMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SetTurretToBuild(buildManager.missileTurretPrefab);
    }
}
