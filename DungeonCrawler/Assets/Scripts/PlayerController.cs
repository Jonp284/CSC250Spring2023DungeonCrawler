using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum ExitDirection {North, South, East, West};

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

        ExitDirection exitDirection = ExitDirection.North;

        if(MasterData.count > 0)
        {
            GameObject previousExit = GameObject.Find("Exit" + (MasterData.count - 1));
            exitDirection = DungeonSetup.ExitDirections[previousExit];
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = Vector3.zero;
        DungeonSetup dungeonSetup = FindObjectOfType<DungeonSetup>();
        
        switch (exitDirection)
        {
            case ExitDirection.North:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    playerMovement = true;
                    movementDirection = this.northExit.transform.position - this.transform.position;
                    MasterData.count++;
                    SceneManager.LoadScene("DungeonRoom1.5");
                }
                break;
            case ExitDirection.South:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    playerMovement = true;
                    movementDirection = this.southExit.transform.position - this.transform.position;
                    MasterData.count++;
                    SceneManager.LoadScene("DungeonRoom3");
                }
                break;
            case ExitDirection.East:
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    playerMovement = true;
                    movementDirection = this.eastExit.transform.position - this.transform.position;
                    MasterData.count++;
                    SceneManager.LoadScene("DungeonRoom5");
                }
                break;
            case ExitDirection.West:
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    playerMovement = true;
                    movementDirection = this.westExit.transform.position - this.transform.position;
                    MasterData.count++;
                    SceneManager.LoadScene("DungeonRoom2");
                }
                break;
        }

        if (playerMovement)
        {
            this.rb.AddForce(movementDirection.normalized * movementSpeed);
        }
            }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == DungeonSetup.CenterPoint)
        {
            playerMovement = false;
            this.rb.velocity = Vector3.zero;
            this.rb.angularVelocity = Vector3.zero;
        }
    }
    

    
}
