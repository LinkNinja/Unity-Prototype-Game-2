using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // An array of game objects that we will call array
    public GameObject[] animalPrefabs;
    //variable to store the animals X spawn position.
    private float spawnRangeX = 20;

    //Variable to store the animals z spawn position.
    private float spawnPosZ = 20;
    //Variable for delaying spawn of animal
    private float startDelay = 2;
    //Variable to invoke repeating every 1.5 seconds.
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        //Unity Method. Takes a method we want to call, and at a certain time will start to call that method and then constantly repeat it.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.S))
        // {
        //     //everytime you press S it will call the SpawnRandomAnimal method/function.
        //     SpawnRandomAnimal();
        // }

    }


    //Everytime we call the spawn animal function it will go through these lines of code until the end and spawn random animals
    void SpawnRandomAnimal()
    {
        //This will be the index to find the different animals in our array to spawn
        //Using random to select which animal you want to choose.
        //this variable only needs to be seen in this method.
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Create a vector 3 variable to store coordinates of animals
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
