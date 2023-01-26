using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LisaStatesDes8
{
    Idle,
    Pursuit
}
public class Enemy1Lisa : MonoBehaviour
{

    [SerializeField] private LisaStatesDes8 currentState;
    [SerializeField] private Transform charDes8;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 initialRotation;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private int scaleFactor;


    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(initialRotation);
    }

    // Update is called once per frame
    void Update()
    {
        setCurrentState();
    }

    private void setCurrentState()
    {
        switch (currentState)
        {
            case LisaStatesDes8.Idle:
                ExecuteIdle();
                break;
            case LisaStatesDes8.Pursuit:
                ExecutePursuit();
                break;
            default:
                Debug.Log(message: "current state is invalid");
                break;
        }
    }

    private void ExecuteIdle()
    {
        LookAtPlayer();
    }

    private void ExecutePursuit()
    {
        var vectorToChar = charDes8.position - transform.position;
        var distance = vectorToChar.magnitude;
        LookAtPlayer();
        if (distance >= 2 * scaleFactor)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            LookAtPlayer();
        }
    }

    private void LookAtPlayer()
    {
        var vectorToChar = charDes8.position - transform.position;
        vectorToChar.y = 0;
        Quaternion rotation = Quaternion.LookRotation(vectorToChar);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

}
