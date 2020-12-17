using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	public GameObject player;
	Animator anim;
	public GameObject door;

	void OnTriggerEnter(Collider other)
		{
			anim = door.gameObject.GetComponent<Animator>();
			

			if (other.gameObject.tag == "Player")
			{
			
				anim.SetBool("open_door", true);
				anim.SetBool("character_nearby", true);
				anim.Play(" glass_door_open", 0, 0.0f);
			}
		}
}
