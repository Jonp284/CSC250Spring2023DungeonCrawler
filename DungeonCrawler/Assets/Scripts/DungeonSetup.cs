using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;
    public GameObject CenterPoint;
    public Dictionary<GameObject, ExitDirection> ExitDirections = new Dictionary<GameObject, ExitDirection>();

    // Start is called before the first frame update
    void Start()
    {
        this.northExit.SetActive(true);
        this.southExit.SetActive(true);
        this.eastExit.SetActive(true);
        this.westExit.SetActive(true);

        ExitDirections.Add(northExit, ExitDirection.North);
        ExitDirections.Add(southExit, ExitDirection.South);
        ExitDirections.Add(eastExit, ExitDirection.East);
        ExitDirections.Add(westExit, ExitDirection.West);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
