using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    public float vitesseTranslation = 3f;
    CharacterController myController;

    // Start is called before the first frame update
    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouvementZ = Input.GetAxis("Vertical") * Vector3.forward * vitesseTranslation * Time.deltaTime;
        Vector3 mouvementX = Input.GetAxis("Horizontal") * Vector3.right * vitesseTranslation * Time.deltaTime;
        Vector3 mouvement = transform.TransformDirection(mouvementX + mouvementZ);
        myController.Move(mouvement);
    }
}
