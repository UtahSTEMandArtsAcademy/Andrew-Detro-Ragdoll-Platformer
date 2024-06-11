using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody RB;
    public float speed = 10;
    public float jumpForce;
    public bool CanJump;
    public Transform cam;
    public Tracker tracker, death_height;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        transform.position = tracker.Location;
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

        if(transform.position.y < death_height.Location.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            tracker.Location = new Vector3(0f, -9f, 0f);
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
