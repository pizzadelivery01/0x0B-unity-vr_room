using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleParticle : MonoBehaviour
{
	public GameObject ParticleSystem;
   // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			ParticleSystem.SetActive(!ParticleSystem.activeInHierarchy);
		}	
	}
}
