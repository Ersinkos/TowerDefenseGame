using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    private GameObject turret;
    private Vector3 positionOffset;

    private Renderer rend;

    private void Start()
    {
        positionOffset = new Vector3(0f, 0.5f, 0f);
        rend = GetComponent<Renderer>();//get the rend component at the start function.We don't have to get component every time OnMouseEnter function works.
        startColor = rend.material.color;//Store the default node color
    }
    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen.");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
