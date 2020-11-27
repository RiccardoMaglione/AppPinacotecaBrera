using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;
    public float speed = 10f;
    public float TurnSmoothTime = 0.1f;
    public float TurnSmoothVelocity;
    



    private void Start()
    {

    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
      

        Vector3 direction = new Vector3(moveHorizontal, 0, moveVertical).normalized;

        if (direction.magnitude >= 0.1)
        {
            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref TurnSmoothVelocity, TurnSmoothTime);
            Vector3 moveDir = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);
            
        }
      
    }
}
