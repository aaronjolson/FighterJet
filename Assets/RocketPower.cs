using UnityEngine;
using System.Collections;

public class RocketPower : MonoBehaviour {

	public int rocketlife = 5;
	public Transform ExplosionParticles;
	
	// Update is called once per frame
	void Update () 
	{
		Destroy(gameObject, rocketlife);
	}
	

	void OnCollisionEnter(Collision collision)
	{
			Destroy (gameObject);
			Instantiate(ExplosionParticles,transform.position,transform.rotation);
	}

}