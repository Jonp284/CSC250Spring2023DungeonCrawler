using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    private bool playerMovement = false;


    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerMovement)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerMovement = true;
                this.rb.AddForce(this.northExit.transform.position * movementSpeed);
                MasterData.count++;
                SceneManager.LoadScene("DungeonRoom1.5");
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                playerMovement = true;
                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                MasterData.count++;
                SceneManager.LoadScene("DungeonRoom2");
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                playerMovement = true;
                this.rb.AddForce(this.southExit.transform.position * movementSpeed);
                MasterData.count++;
                SceneManager.LoadScene("DungeonRoom3");
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerMovement = true;
                this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
                MasterData.count++;
                SceneManager.LoadScene("DungeonRoom5");
            }
        } 
    }

    void OnCollisionEnter(Collision collision)
    {
        playerMovement = false;
    }
    
}
