using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu
    (fileName = "New Location",
        menuName = "New Location",
        order = 0)
]
public class LocationScriptableObject : ScriptableObject
{
    
    
    public string locationName;
    public string locationDesc;

    public LocationScriptableObject north;
    public LocationScriptableObject south;
    public LocationScriptableObject west;
    public LocationScriptableObject east;
    public LocationScriptableObject northeast;
    public LocationScriptableObject northwest;
    public LocationScriptableObject southeast;
    public LocationScriptableObject southwest;

    public void PrintLocation()
    {
        string printStr =
            "\nLocation Name: " + locationName +
            "\nLocation Description: " + locationDesc;
        
        Debug.Log(printStr);
    }

    public void UpdateCurrentLocation(GameManager gm)
    {
        gm.titleUI.text = locationName;
        gm.descriptionUI.text = locationDesc;

        if (north == null)
        {
            gm.buttonN.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonN.gameObject.SetActive(true);
            north.south = this;
        }
        
        if (south == null)
        {
            gm.buttonS.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonS.gameObject.SetActive(true);
            south.north = this;
        }
        
        if (west == null)
        {
            gm.buttonW.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonW.gameObject.SetActive(true);
            west.east = this;
        }
        
        if (east == null)
        {
            gm.buttonE.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonE.gameObject.SetActive(true);
            east.west = this;
        }
        
        if (northeast == null)
        {
            gm.buttonNE.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonNE.gameObject.SetActive(true);
            northeast.southwest = this;
        }
        
        if (northwest == null)
        {
            gm.buttonNW.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonNW.gameObject.SetActive(true);
            northwest.southeast = this;
        }
        
        if (southeast == null)
        {
            gm.buttonSE.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonSE.gameObject.SetActive(true);
            southeast.northwest = this;
        }
        
        if (southwest == null)
        {
            gm.buttonSW.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonSW.gameObject.SetActive(true);
            southwest.northeast = this;
        }
    }
}
