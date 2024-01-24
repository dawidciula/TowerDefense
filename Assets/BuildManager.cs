using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Wiêcej ni¿ jeden BuildManager na scenie!");
        }
        instance = this;

    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;


    public bool CanBuild
    {
        get { return turretToBuild != null; }
    }


    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Niewystarcz¹jaco pieniêdzy!");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;


        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Wie¿a zbudowana! Pieniêdzy zosta³o: " + PlayerStats.Money);
    }


    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
