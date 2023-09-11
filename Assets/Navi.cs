using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navi : MonoBehaviour
{
    public GameObject parentModel;

    private float rotateSpeed = 200.0f;
    private float panSpeed = 0.05f;
    private Vector3 lastPos;
    private float zoomScale = 15.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1))
        {
            CamOrbit();
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            lastPos = Input.mousePosition;
        }
        if(Input.GetKey(KeyCode.Mouse0))
        {
            CamPan();
        }
        CamZoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    private void CamOrbit()
    {
        if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            float verInput = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            float horInput = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, -verInput);
            transform.Rotate(Vector3.up, horInput, Space.World);    
        }
    }

    private void CamPan()
    {
        if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0){
            // pan camera
            Vector3 delta = Input.mousePosition - lastPos;
            transform.position -= transform.right * delta.x * panSpeed;
            transform.position -= transform.up * delta.y * panSpeed;
            lastPos = Input.mousePosition;
        }
    }

    private void CamZoom(float zoomDiff)
    {
        if(zoomDiff != 0)
        {
            // zoom in/out without changing fov
            transform.position += transform.forward * zoomDiff * zoomScale;
        }    
    }

    public Vector3 GetPerspectivePos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(transform.forward, 0.0f);
        float dist;
        plane.Raycast(ray, out dist);
        return ray.GetPoint(dist);
    }

}
