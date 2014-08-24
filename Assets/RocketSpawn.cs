using UnityEngine;
using System.Collections;

public class RocketSpawn : MonoBehaviour {
	public GameObject RocketPrefab;
	public static bool rocketFired;
	public int rocketTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("space"))
		{
			Instantiate(RocketPrefab, transform.position, transform.rotation);
		}
	}
	
}
