using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;


    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher");
        buildManager.SelectTurretToBuild(missleLauncher);
    }
}
