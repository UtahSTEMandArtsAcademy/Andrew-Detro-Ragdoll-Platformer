using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody RB;
    public float speed = 10;
    public float jumpForce;
    public bool CanJump;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CamForward = cam.forward;
        Vector3 CamRight = cam.right;
        CamForward.y = 0;
        CamRight.y = 0;
        float hv = Input.GetAxis("Horizontal");
        float vh = Input.GetAxis("Vertical");
        Vector3 ForwardRelative = vh * CamForward;
        Vector3 RightRelative = hv * CamRight;
        Vector3 DIR = ForwardRelative + RightRelative;
        
        
            RB.AddForce(DIR * speed * Time.deltaTime);
        
        
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
        
        if(CanJump == true)
        {
            speed = 0;
        }
        else
        {
            speed = 10000;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        CanJump = true;
    }
    private void OnTriggerExit(Collider other)
    {
        CanJump = false;
    }
}
