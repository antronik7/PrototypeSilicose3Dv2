using UnityEngine;
using System.Collections;

public class cameraRotation : MonoBehaviour {

    public Transform target;
    public Transform height;
    public Transform with;

    private float z;
    private float x;

    private float t;

	// Use this for initialization
	void Start () {
        transform.LookAt(target);

        t = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            
            //transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * 5);

            t = t + (Input.GetAxis("Mouse X") / 40);

            z = height.position.z * Mathf.Cos(t);
            x = with.position.x * Mathf.Sin(t);

            transform.position = new Vector3(x, transform.position.y, z);
        }
        else
        {
            t = t + (Input.GetAxis("Horizontal") / -50);

            z = height.position.z * Mathf.Cos(t);
            x = with.position.x * Mathf.Sin(t);

            transform.position = new Vector3(x, transform.position.y, z);
        }

        

        Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * 50;
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 30, 60);



        transform.LookAt(target);
    }
}
