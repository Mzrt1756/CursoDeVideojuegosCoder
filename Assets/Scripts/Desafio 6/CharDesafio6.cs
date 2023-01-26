using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDesafio6 : MonoBehaviour
{
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private BulletDesafio5 bulletDesafio5;
    [SerializeField] private int speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        var isShooting = Input.GetKeyDown(KeyCode.Mouse0);
        if (isShooting)
        {
            Shoot();
        }
        Run();

    }
    private void Shoot()
    {
        Instantiate(bulletDesafio5, shootingPoint.position, shootingPoint.rotation);
    }
    
    private void Run()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
    }
}
