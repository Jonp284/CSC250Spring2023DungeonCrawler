using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;

    // Start is called before the first frame update
    void Start()
    {
        this.northExit.SetActive(true);
        this.southExit.SetActive(true);
        this.eastExit.SetActive(true);
        this.westExit.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
