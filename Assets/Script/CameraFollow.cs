using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerTransform;

    private GameObject player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;
        }
    }
    void LateUpdate()
    {
        
        if (!player)
            return;

        tempPos = transform.position;
        tempPos.x = playerTransform.position.x;

        if (tempPos.x < minX)
            tempPos.x = minX;

        if (tempPos.x > maxX)
            tempPos.x = maxX; 
        transform.position = tempPos;
        
    }


} // class
