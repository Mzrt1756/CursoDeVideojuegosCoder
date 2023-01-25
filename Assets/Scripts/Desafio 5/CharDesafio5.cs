using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDesafio5 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private BulletDesafio5 bulletDesafio5;
    public float horizontalSpeed = 2.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(x: horizontal, y: 0, z: vertical);
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        Rotate(h);
        Move(direction);
        var isShooting = Input.GetKeyDown(KeyCode.Mouse0);
        if(isShooting)
        {
            Shoot();
        }
        
    }
    private void Shoot()
    {
        Instantiate(bulletDesafio5, shootingPoint.position,shootingPoint.rotation);
    }
    private void Move(Vector3 moveDirection)
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    private void Rotate(float hRotation)
    {
        transform.Rotate(0, hRotation, 0);
    }

}
