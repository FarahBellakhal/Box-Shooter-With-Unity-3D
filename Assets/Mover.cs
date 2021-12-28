using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public bool moveVertically = true;
    public bool moveHorizontally = false;
    public bool doSpin = true;

    public float centerPosition = 0f;
    public float moveSpeed = 2f;
    public float delta = 5f;                        //delta c'est l'amplitude d'oscillation
    public float spinSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        if (moveVertically)
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * moveSpeed, delta) + centerPosition, transform.position.z);
        }
        if (moveHorizontally)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * moveSpeed, delta) + centerPosition, transform.position.y, transform.position.z);
        }
        if (doSpin)
        {
            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }
    }
}
