﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    public float backgroundSize;
    private Transform cameraTransform;
    private Transform[] layers;
    private float viewZone = 50;
    private int leftIndex; //layer on the very left
    private int rightIndex; //layer on the very right


   

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        layers = new Transform[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            layers[i] = transform.GetChild(i);

            leftIndex = 0;
            rightIndex = layers.Length - 1;
        }

        
    }
    private void ScrollLeft()
    {
        int lastRight = rightIndex;
        //layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x  - backgroundSize);
        layers[rightIndex].position = new Vector3(1 * (layers[leftIndex].position.x - backgroundSize), -1);
        leftIndex = rightIndex; //leftone is now the one on the right
        rightIndex--; 
        if(rightIndex < 0)
        {
            rightIndex = layers.Length-1;
        }
    }
    private void ScrollRight()
    {
        int lastLeft = leftIndex;
        //layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
        layers[leftIndex].position = new Vector3(1*(layers[rightIndex].position.x + backgroundSize), -1); 
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
        {
            leftIndex = 0;
        }
    }
    private void Update()
    {
        if(cameraTransform.position.x <(layers[leftIndex].transform.position.x + viewZone)){
            ScrollLeft();
        }
        if (cameraTransform.position.x >(layers[rightIndex].transform.position.x -viewZone)){
            ScrollRight();
        }
    }
}
