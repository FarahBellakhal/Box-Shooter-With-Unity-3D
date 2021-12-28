using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tireur : MonoBehaviour
{
     public GameObject projectile;
    public float power = 10.0f;
    public AudioClip shootSFX;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1")|| Input.GetButtonDown("Jump"))
        {
            if (projectile)
            {
                //GameObject newprojectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;
                GameObject newprojectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;

               
                if (!newprojectile.GetComponent<Rigidbody>())
                {
                    newprojectile.AddComponent<Rigidbody>();
                }

              
                newprojectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);

                if (shootSFX)
                {
                    if (newprojectile.GetComponent<AudioSource>())
                    { // the projectile has an AudioSource component
                      // play the sound clip through the AudioSource component on the gameobject.
                      // note: The audio will travel with the gameobject.
                        newprojectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                    }
                    else
                    {
                        // dynamically create a new gameObject with an AudioSource
                        // this automatically destroys itself once the audio is done
                        AudioSource.PlayClipAtPoint(shootSFX, newprojectile.transform.position);
                    }
                }


            }

        }
        

    }
}
