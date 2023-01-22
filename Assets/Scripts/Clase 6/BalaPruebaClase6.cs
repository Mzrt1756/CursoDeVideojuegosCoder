using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPruebaClase6 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime = 5;

    // Start is called before the first frame update
    void Start()
    {
        lifetime += Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        MoveForwards();
        Countdown();
    }

    private void Countdown()
    {
        if (lifetime <= Time.time)
        {
            KillBullet();
        }
    }

    private void KillBullet()
    {
        Debug.Log(message: "Bullet killed");
        Destroy(gameObject);
    }
    private void MoveForwards()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
