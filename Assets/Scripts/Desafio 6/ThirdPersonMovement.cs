using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField] private Transform tpcamera;
    private float speed;
    [SerializeField] private float normalSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float turnSmoothTime = 0.1f;
    [SerializeField] private float turnSmoothVelocity;
    [SerializeField] private int rotationSpeed;
    private bool isRunning ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(GetMoveVector());
        RotCharacter(GetRotationAmount());
        Run();
        RotationCharacter(GetMoveVector());

    }
    private void Move(Vector3 moveDir)
    {
        var transform1 = transform;
        transform1.position += (moveDir.x * transform1.right + moveDir.z * transform1.forward) * (speed * Time.deltaTime);
    }

    private void RotationCharacter(Vector3 direction)
    {
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + tpcamera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            transform.position += moveDir.normalized * speed * Time.deltaTime;
        }
    }
    private void RotCharacter(float rotateAmount)
    {
        transform.Rotate(Vector3.up, rotateAmount * Time.deltaTime * rotationSpeed, Space.Self);
    }

    private float GetRotationAmount()
    {
        return Input.GetAxis("Mouse X");
    }

    private Vector3 GetMoveVector()
    {
        var l_horizontal = Input.GetAxisRaw("Horizontal");
        var l_vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(l_horizontal, 0, l_vertical).normalized;
        return direction;
    }
    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
            speed = runSpeed;

        }
        else
        {
            isRunning = false;
            speed = normalSpeed;
        }
    }
 
}




