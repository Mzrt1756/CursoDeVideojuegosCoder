using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDesafio5 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        lifetime += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
        KillBullet();
    }

    private void KillBullet()
    {
        if (lifetime <= Time.time)
        {
            Destroy(gameObject);
        }

    }
    private void BulletMovement()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
