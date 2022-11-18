using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //If both object collide with each other they will both be removed in the game
    private void OnTriggerEnter(Collider other)
    {
        //The objects are the food and the animals
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
