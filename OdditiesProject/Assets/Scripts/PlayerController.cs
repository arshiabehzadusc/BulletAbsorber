using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    private List<string> inventory = new List<string>();

    private bool pickUp;
    // Start is called before the first frame update
    void Start()
    {
        pickUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = moveSpeed * Time.deltaTime * new Vector3(horizontalInput, verticalInput, 0f);
        transform.position += movement;

        if (Input.GetKeyDown(KeyCode.E))
        {
            pickUp = true;
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        // Code to execute when a trigger collision starts
        if (pickUp)
        {
            Debug.Log("Pick up: " + other.gameObject.name);
            inventory.Add(other.gameObject.name);
            print("Inventory: ");
            foreach (string item in inventory)
            {
                print(item+ ", ");
            }
            pickUp = false;
            Destroy(other.gameObject);
        }
    }
}


    
