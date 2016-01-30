﻿using UnityEngine;
using System.Collections;

public class spawnPoint : MonoBehaviour {

	public GameObject laser;
	public int key;
	private bool beamOn = false;

	private GameObject clone;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MidiJack.MidiMaster.GetKeyDown(key) && beamOn == false) 
		{
			Debug.Log("Key Pressed");
			beamOn = true;

			clone = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
		}

		if (MidiJack.MidiMaster.GetKeyUp(key) && beamOn == true)
		{
			beamOn = false;
			Destroy(clone);
		}


	}
}
