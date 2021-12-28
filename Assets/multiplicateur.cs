 using UnityEngine;
using System.Collections;

public class multiplicateur : MonoBehaviour
{
    // public variables
    public float secondsBetweenSpawning = 0.1f;
    public float xMinRange = -25.0f;
    public float xMaxRange = 25.0f;
    public float yMinRange = 8.0f;
    public float yMaxRange = 25.0f;
    public float zMinRange = -25.0f;
    public float zMaxRange = 25.0f;
    public GameObject[] multipliedObjects; // what prefabs to spawn

    private float nextMultiplicationTime;

    // Use this for initialization
    void Start()
    {
        // determine when to spawn the next object
        nextMultiplicationTime = Time.time + secondsBetweenSpawning;
    }

    // Update is called once per frame
    void Update()
    {
        // exit if there is a game manager and the game is over
        if (GameManager.gm)
        {
            if (GameManager.gm.gameIsOver)
                return;
        }

        // if time to spawn a new game object
        if (Time.time >= nextMultiplicationTime)
        {
            // Spawn the game object through function below
            MakeThingTomultiply();

            // determine the next time to spawn the object
            nextMultiplicationTime = Time.time + secondsBetweenSpawning;
        }
    }

    void MakeThingTomultiply()
    {
        Vector3 copyPosition;

        // get a random position between the specified ranges
        copyPosition.x = Random.Range(xMinRange, xMaxRange);
        copyPosition.y = Random.Range(yMinRange, yMaxRange);
        copyPosition.z = Random.Range(zMinRange, zMaxRange);

        // determine which object to spawn
        int objectToCopy = Random.Range(0, multipliedObjects.Length);

        // actually spawn the game object
        GameObject spawnedObject = Instantiate(multipliedObjects[objectToCopy], copyPosition, transform.rotation) as GameObject;

        // make the parent the spawner so hierarchy doesn't get super messy
        spawnedObject.transform.parent = gameObject.transform;
    }
}
