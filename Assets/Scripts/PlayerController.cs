using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //This is being used to store the INPUT.GETAXIS variables from the input manager
    public float horizontalInput;
    //The speed at which our player will move from left to right
    public float speed = 10.0f;

    //public float leftBoundary = -10.0f;
    //public float rightBoundary = 10.0f;

    public float xRange = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //here we are assigning the variable equal to the Input manager. From here
        // you may assign inputs from the input manager. In this case Horizontal will offer 
        // horizontal input == -1 or +1 which means our character whill move left or right.
        horizontalInput = Input.GetAxis("Horizontal");

        //Here we begin to translate the position of the player from VECTOR 3 RIGHT and multiply it by time so that its not ever 60 fps
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        //iF THE SPACE KEY IS PRESSED DOWN SOMETHING WILL HAPPEN
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate is another way of saying were going to create an object.
            // Instantiate is for creating copes for objects that already exist.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }





    }
}
