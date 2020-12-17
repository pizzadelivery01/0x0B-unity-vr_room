using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ToggleLight : MonoBehaviour
{
	private readonly SteamVR_Action_Boolean InteractWithHeldItem = SteamVR_Actions.default_InteractWithHeldItem;
    public GameObject whitelight;
	
	// Start is called before the first frame update
    void Start()
    {
	}

    // Update is called once per frame
    void Update()
    {
        if (this.InteractWithHeldItem.GetChanged(SteamVR_Input_Sources.Any))
		{
			Toggle();
		}
    }
	private void FixedUpdate()
	{
		if (whitelight.activeInHierarchy)
		{

			Ray raycast = new Ray(transform.position, transform.up);
            RaycastHit hit;
            bool bHit = Physics.Raycast(raycast, out hit);

			//Debug.Log(hit.collider.name);

		}
	}
	private void Toggle()
	{
		whitelight.SetActive(!whitelight.activeInHierarchy);
	}
}
