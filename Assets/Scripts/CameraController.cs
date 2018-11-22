﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour {

    public Transform target;

    public Tilemap theMap;
    private Vector3 bottomLeftLimit;
    private Vector3 topRightLimit;

    private float halfHeight;
    private float halfWitdth;


	// Use this for initialization
	void Start () {
        target = PlayerController.instance.transform;

        halfHeight = Camera.main.orthographicSize;
        halfWitdth = halfHeight * Camera.main.aspect;

        bottomLeftLimit = theMap.localBounds.min + new Vector3(halfWitdth,halfHeight,0f);
        topRightLimit = theMap.localBounds.max + new Vector3(-halfWitdth,-halfHeight,0f);
	}
	
	// LateUpdate is called once per frame after Update
	void LateUpdate () {
        transform.position = new Vector3(target.position.x,target.position.y, transform.position.z);

        //keep the camera inside the bounds 
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y ,bottomLeftLimit.y, topRightLimit.y), transform.position.z);
	}
}