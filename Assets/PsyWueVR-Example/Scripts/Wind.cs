using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wind : MonoBehaviour {

	Dictionary<float, Vector3> windlayers;

	void Start () {
		windlayers = new Dictionary <float,Vector3>();
		windlayers.Add (0,new Vector3(0,0,0));
		windlayers.Add (2,new Vector3(-0.2f,0,0));
		windlayers.Add (5,new Vector3(0.2f,0,0));
		windlayers.Add (10,new Vector3(0.5f,0,0));
		windlayers.Add (12,new Vector3(0.2f,0,0));
		windlayers.Add (15,new Vector3(-0.2f,0,0));
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
