using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetbehaviour : MonoBehaviour
{ public int scoreAmount =10;
  public float timeAmount=0.0f;
  public GameObject explosionPrefab;
    private void OnCollisionEnter(Collision collision)
    {
       
        if (GameManager.gm)
        {
            if(GameManager.gm.gameIsOver) { return;}
 
         if (collision.gameObject.tag=="projectile") 
         {   
             if(explosionPrefab)
             {
                 Instantiate(explosionPrefab,transform.position,transform.rotation);
             }
             if(GameManager.gm)
             {
                 GameManager.gm.targetHit(scoreAmount,timeAmount);
             }
             Destroy(gameObject);
          }
             
        }
    }
}
