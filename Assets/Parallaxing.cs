using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {
    public Transform[] backgrounds; //List of all the back and foregrounds to be parallaxed
    private float[] parallaxScales; //The proportion of the camera's movements to move the bg by
    public float smoothing = 1f; //how smooth the parallax will be; Make sure to set this  above 0

    private Transform cam; //ref to main camera's transform
    private Vector3 previousCamPos; //the position of camera in prev frame

    private void Awake() //great for references
    {
        cam = Camera.main.transform;
    }

    void Start()
    {
        //The prev frame had the current frame's cam position
        previousCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];

        //assigning corresponding parallaxScales
        for(int i =0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
       
    }

    void Update()
    {
        for(int i =0; i < backgrounds.Length; i++)
        {
            //the parallax is the opposite of the camera movement bc prev frame multiplied by the scale
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];


            //set a target x pos whihc is curr pos plus parallax
            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            //create a target position which is the bg's current position with the  target x
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);


            //fade between curr pos and the target pos
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
        //set prevCamPOs to the camera's position at the end of frame
        previousCamPos = cam.position;
    }
}
