using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI titleUI;
    public TextMeshProUGUI descriptionUI;

    public LocationScriptableObject currentLocation;

    public Button buttonN;
    public Button buttonS;
    public Button buttonW;
    public Button buttonE;
    public Button buttonNE;
    public Button buttonNW;
    public Button buttonSE;
    public Button buttonSW;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentLocation.PrintLocation();
        currentLocation.UpdateCurrentLocation(gm:this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveDir(string dirString)
    {
        switch (dirString)
        {
            case "N":
                currentLocation = currentLocation.north;
                break;
            case "S":
                currentLocation = currentLocation.south;
                break;
            case "E":
                currentLocation = currentLocation.east;
                break;
            case "W":
                currentLocation = currentLocation.west;
                break;
            case "NE":
                currentLocation = currentLocation.northeast;
                break;
            case "NW":
                currentLocation = currentLocation.northwest;
                break;
            case "SE":
                currentLocation = currentLocation.southeast;
                break;
            case "SW":
                currentLocation = currentLocation.southwest;
                break;
        }
        
        currentLocation.UpdateCurrentLocation(gm:this);
    }
}
