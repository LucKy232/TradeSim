using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Station : MonoBehaviour {

	List<TradeResource> resList = new List<TradeResource>();

	// Use this for initialization
	void Start () 
	{
		TradeResource rawiron = new TradeResource ("Raw Iron",120,0.80f,1.20f);
		resList.Add (rawiron);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
