using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPruebaClase6 : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForwards();
    }

    private void MoveForwards()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
