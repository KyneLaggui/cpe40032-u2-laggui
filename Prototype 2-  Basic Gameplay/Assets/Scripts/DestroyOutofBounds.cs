using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 30;//Food limit boundary
    private float lowerBound = -10;//Animals limit boundary
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, it will remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < lowerBound)
        {
            //If an animal goes past the player it will display game over to the console
            Debug.Log("Game Over Nice try!");
            Destroy(gameObject);

        }
    }
}
