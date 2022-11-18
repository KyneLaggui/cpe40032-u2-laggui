using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; //To get the input of the user
    public float speed= 20.0f;//Speed of the character
    public float xRange = 15.0f;//Boundary of the character left and right

    public GameObject projectilePrefab;//To get the food prefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)//To limit the character in exceeding in the left position
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)//To limit the character in exceeding in the right position
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");//To get what the user is pressing
        transform.Translate(Vector3.right * horizontalInput *Time.deltaTime *speed );//Movement of the player

        //If the user press the space button it will launch what is binded on the projectilePrefab
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
