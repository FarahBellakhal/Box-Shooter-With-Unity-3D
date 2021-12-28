using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag=="projectile")
			GameManager.gm.NextLevel();
	}}
