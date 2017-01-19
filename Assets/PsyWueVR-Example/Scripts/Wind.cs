using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wind : MonoBehaviour {

	Dictionary<float, Vector3> windlayers;

	void Start () {
		windlayers = new Dictionary <float,Vector3>();
		windlayers.Add (0.5f,new Vector3(0,0,0));
		windlayers.Add (1.2f,new Vector3(-0.2f,0,0));
		windlayers.Add (1.6f,new Vector3(0.2f,0,0));
		windlayers.Add (2,new Vector3(0.4f,0,0));
		windlayers.Add (3,new Vector3(0.6f,0,0));
		windlayers.Add (3.5f,new Vector3(0.4f,0,0));
		windlayers.Add (3.8f,new Vector3(0.2f,0,0));
		windlayers.Add (4,new Vector3(0,0,0));
		windlayers.Add (4.2f,new Vector3(-0.2f,0,0));
		windlayers.Add (4.5f,new Vector3(-0.4f,0,0));
		windlayers.Add (5,new Vector3(-0.6f,0,0));
		windlayers.Add (6,new Vector3(-0.4f,0,0));
	}

	public Vector3 getWind(Vector3 position){
		foreach (KeyValuePair<float, Vector3> wind in windlayers) {
			if (position.y <= wind.Key) {
				return wind.Value;
			}
		}
		return new Vector3(0,0,0);
	}
}
