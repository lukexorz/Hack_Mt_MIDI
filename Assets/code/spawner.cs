﻿using System;
using UnityEditor;
using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public string levelname = "luke.txt";
	public double time;
	public int note;
	public float Duration;
	public double timer;

	private System.IO.StreamReader file;
	private string line;
	public GameObject noteObject;
	private GameObject clone;
	private int length;

	// Use this for initialization
	void Start () {
		file = new System.IO.StreamReader(Application.dataPath +"/gen_level/"+ levelname);
		length = Int32.Parse(file.ReadLine());
        line = file.ReadLine();
        //int counter = 0;
        //int size=Int32.Parse(file.ReaTdLine());
		//timer=0;
        //UnityEngine.Debug.Log(line);
        //while ((line = file.ReadLine()) != null)
        //{
        //	string[] row=line.Split(' ');
       // 	note=Int32.Parse(row[1]);
		//	time=float.Parse(row[0]);

			//StartCoroutine(coroutine(time));// start spin lock
			//Debug.Log(timer);
        	
			//noteFall clonescript = clone.GetComponent<noteFall>();
			//note to change this to Int32.Parse at some time
			//clonescript.setTimeOffset(float.Parse(row[0]));
			//clone.GetComponent<noteFall>().timeOffset=float.Parse(row[0]);

			//clone.GetComponent<noteFall>().setTimeOffset(float.Parse(row[0]));
			//Debug.Log(float.Parse(row[0]));
       // }
    // file.Close();  
	}
	public IEnumerator coroutine(double t) {
		
		yield return new WaitForSeconds((int)t); // NOOOOOOOOOO DUMB DUMB

	}

	// Update is called once per frame
	void Update () 
	{
		timer = timer + Time.deltaTime;
		string[] row = line.Split(' ');

		Debug.Log(row[0]);
		if (float.Parse(row[0]) < timer)
		{
			//If it's time to spawn a new note, do so
			Debug.Log("SPawn note");
			clone = Instantiate(noteObject, transform.position, Quaternion.identity) as GameObject;
			note=Int32.Parse(row[1]);
			clone.transform.Translate(Vector3.right * (note-56));
			Debug.Log(note);

			//And read the next line
		    line = file.ReadLine();
		}

		//TODO: REPLACE THIS SPIN WAIT


		//Debug.Log(timer);
		/*
		String[] row = line.Split(' ');
		time = float.Parse(row[0]);
		note=Int32.Parse(row[1]);
		Duration=float.Parse(row[2]);
		*/	
	}
	public double getTime(){
		return timer;

	}
}
