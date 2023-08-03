using UnityEngine; 
    using System.Collections; 

    public class Mouserotate : MonoBehaviour { 

       public Rigidbody rb;
    public float strengthx= 5;
    public float strengthy= 2;
    public float minFov = 15f;
    public float maxFov = 90f;
    public float sensitivity = 10f;
    float rotX;
    float rotY;
    bool rotate;

        void OnMouseDrag()
        {
            rotate = true;
            rotX = Input.GetAxis("Mouse X") * strengthx;
            rotY = Input.GetAxis("Mouse Y") * strengthy;
        }
        void OnMouseUp() 
        {
            rotate = false;
        }
    private void Update()
    { RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if (Physics.Raycast(ray, out hit)){

        float fov = Camera.main.fieldOfView;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }
    }
    void FixedUpdate()
    {
        if (rotate)
        {
            rb.AddTorque(-rotY, -rotX, 0);
        }
        else{
            rb.angularVelocity = new Vector3(0,0,0);
        }
    }
    }