using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float dragSpeed = 2f;
    private Vector3 dragOrigin;
    private Vector3 Difference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return;
        }

        if (Input.GetMouseButton(0))
        {

            Vector3 diff = (Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position) * dragSpeed;
            Debug.Log(diff);

            transform.position = dragOrigin - diff;
        }
    }

}
