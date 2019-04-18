﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
	public GameObject prefabProjectile;
	public GameObject launchPoint;
	public Vector3 launchPos;
	public GameObject projectile;
	public bool aimingMode;

	void Awake() {
		Transform launchPointTrans = transform.Find ("LaunchPoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive (false);
		launchPos = launchPointTrans.position;
	}

	void OnMouseEnter() {
		//print ("Slingshot:OnMouseEnter()");
		launchPoint.SetActive(true);
	}

	void OnMouseDown() {
		aimingMode = true;
		projectile = Instantiate (prefabProjectile) as GameObject;
		projectile.transform.position = launchPos;
		projectile.GetComponent<Rigidbody> ().isKinematic = true;
	}

	void OnMouseExit() {
		//print ("Slingshot:OnMouseExit()");
		launchPoint.SetActive(false);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
