using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructeur : MonoBehaviour
{
    private void Awake () 
    {
        Object.Destroy(gameObject, 1.0f);
    }
}

