using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject target;
	public float cameraSpeed;
	private Vector3 targetPos;
    public BoxCollider2D boundBox;
    private Vector3 minBounds;
    private Vector3 maxBounds;
    public GameObject boundCenter;

    private Camera theCamera;
    private float halfHeight;
    private float halfWidth;
    private static bool cameraExists;

   
    void Awake () {
        DontDestroyOnLoad(transform.gameObject);

        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

      
        minBounds = boundBox.bounds.min;
        //furthest down and left point of bound
        maxBounds = boundBox.bounds.max;//top right

        theCamera = GetComponent<Camera>();
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;

	}
	
	// Update is called once per frame
	void Update () {


      


		targetPos = new Vector3 (target.transform.position.x, target.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, targetPos, cameraSpeed * Time.deltaTime);
        //If (leftEdgeOfCamera < leftEdgeOfWorld) then
        //      leftEdgeOfCamera = leftEdgeOfWorld + (some small value)
        //Do the same for y
        //And for right edge

        float leftXEdge = boundBox.bounds.center.x - (boundBox.bounds.size.x /2);
        float rightXEdge = boundBox.bounds.center.x + (boundBox.bounds.size.x /2);
        float upYEdge = boundBox.bounds.center.y + (boundBox.bounds.size.y / 2);
        float bottonYEdge = boundBox.bounds.center.y - (boundBox.bounds.size.y / 2);
        float cameraLeftX = transform.position.x - halfWidth;
        float cameraRightX = transform.position.x + halfWidth;
        float cameraUpY = transform.position.y + halfHeight;
        float cameraBotY = transform.position.y - halfHeight;


        if (cameraLeftX < leftXEdge) {
            cameraLeftX = leftXEdge + 0.01f;
            transform.position = new Vector3(cameraLeftX + halfWidth, transform.position.y, transform.position.z);
        }
        if (cameraRightX> rightXEdge) {
            cameraRightX = rightXEdge - 0.01f;
            transform.position = new Vector3(cameraRightX - halfWidth, transform.position.y, transform.position.z);
        }
        if(cameraBotY < bottonYEdge)
        {
            cameraBotY = bottonYEdge + 0.01f;
            transform.position = new Vector3(transform.position.x, cameraBotY+ halfHeight, transform.position.z);
        }
       if(cameraUpY> upYEdge)
        {
            cameraUpY = upYEdge - 0.01f ;
            transform.position = new Vector3(transform.position.x, cameraUpY - halfHeight, transform.position.z);
        }


       








       



    }

 

    
}
