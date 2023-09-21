using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;
    

    private Renderer rend;

    BuildManager buildManager;

    public Vector3 GetBuildPosition()
    {
        return transform.position+positionOffset;
    }
    private void Start()
    {
        buildManager = BuildManager.instance;
        positionOffset = new Vector3(0f, 0.5f, 0f);
        rend = GetComponent<Renderer>();//get the rend component at the start function.We don't have to get component every time OnMouseEnter function works.
        startColor = rend.material.color;//Store the default node color
    }
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen.");
            return;
        }

        buildManager.BuildTurretOn(this);
    }
    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
