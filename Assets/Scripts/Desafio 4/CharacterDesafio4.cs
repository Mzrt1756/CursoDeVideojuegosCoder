using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDesafio4 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private BulletDesafio4 bulletPrefab;
    [SerializeField] private float shootingTimer;
    private float _shootingTimerInner;

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
        Move(direction);
        var isShooting = Input.GetKeyDown(KeyCode.Mouse0);
        var isBulletGrowing = Input.GetKeyDown(KeyCode.Space);
        var isBulletShrinking = Input.GetKeyDown(KeyCode.V);
        if (isShooting && _shootingTimerInner <= Time.time)
        {
            Shoot();
        }
        if (isBulletGrowing)
        {
            BulletGrow();
        }

        if (isBulletShrinking)
        {
            BulletShrink();
        }


    }
    private void Shoot()
    {
        _shootingTimerInner = shootingTimer + Time.time;
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
    }
    private void Move(Vector3 moveDirection)
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }
    private void BulletGrow()
    {
        bulletPrefab.transform.localScale += Vector3.one * 2;
    }

    private void BulletShrink()
    {
        bulletPrefab.transform.localScale -= Vector3.one * 2;
    }
}

