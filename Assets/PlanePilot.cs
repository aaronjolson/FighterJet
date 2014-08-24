using UnityEngine;
using System.Collections;

public class PlanePilot : MonoBehaviour {
	public float speed = 90.0f;
	
	void Start () {
	}

	void Update (){
//		Debug.Log(speed);
		if (Input.GetKeyDown (KeyCode.Q)) {
			speed = speed + 50.0f;
		}
	}

	void FixedUpdate () {

		transform.position += transform.forward * Time.deltaTime * speed;

		speed -= transform.forward.y * Time.deltaTime * 50.0f;

		if (speed < 35.0f) {
			speed = 35.0f;
		}
		else if (speed >= 150){
			speed = 150.0f;
		}

		transform.Rotate( -Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight( transform.position);

		if (terrainHeightWhereWeAre > transform.position.y){
			transform.position = new Vector3(transform.position.x, terrainHeightWhereWeAre, transform.position.z);
		
		}
	}
}
