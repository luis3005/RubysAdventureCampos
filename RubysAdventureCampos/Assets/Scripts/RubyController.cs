using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Creating the two vareiables that use the pre built axes
        float horitzontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //create the movement vector
        Vector2 position = transform.position;

        //changing the x and y position 
        position.x = position.x + 3.0f * horitzontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        // Set the update position 
        transform.position = position; 

    }
}
