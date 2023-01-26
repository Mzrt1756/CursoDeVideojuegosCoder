using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3RedPyramid : MonoBehaviour
{
    
    [SerializeField] private Transform charDes8;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 initialRotation;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float scaleFactor; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ExecutePursuit();       
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
