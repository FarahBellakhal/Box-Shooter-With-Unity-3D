using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    public bool moveVertically = false;
    public bool moveHorizontally = true;
    public float vitesseTranslation = 2f;
    public float vitesseRotation = 180f;
    public bool doRotate = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveHorizontally)
        {
            gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * vitesseTranslation * Time.deltaTime);
        }
        if (moveVertically)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * vitesseTranslation * Time.deltaTime);
        }
        if (doRotate)
        {
            gameObject.transform.Rotate(Vector3.up * vitesseRotation * Time.deltaTime);
        }
    }
}
