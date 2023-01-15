using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform pointOfShoot;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bullet, pointOfShoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
