using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Rabbit : MonoBehaviour
{
    [SerializeField] private Transform charDes8;
    [SerializeField] private Vector3 initialRotation;
    [SerializeField] private float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }


    private void LookAtPlayer()
    {
        var vectorToChar = charDes8.position - transform.position;
        vectorToChar.y = 0;
        Quaternion rotation = Quaternion.LookRotation(-vectorToChar);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

    }
}
