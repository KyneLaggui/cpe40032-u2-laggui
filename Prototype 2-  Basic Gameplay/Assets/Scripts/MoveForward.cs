using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;//The speed of the food

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Adding a movement and applying the speed for the food projectile
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
    }
}
