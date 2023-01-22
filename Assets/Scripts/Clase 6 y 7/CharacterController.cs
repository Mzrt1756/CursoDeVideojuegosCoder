using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float damageToTake;
    [SerializeField] private bool isParalyzed;
    [SerializeField] private bool isInGodMode;
    [SerializeField] private BalaPruebaClase6 bulletPrefab;
    [SerializeField] private Transform shootingPoint;
    public float timeToMove;
    public float timeToMoveLeft;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isInGodMode || !isParalyzed && health > 0)
        {
            Move();
        }*/

        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(x: horizontal, y: 0, z: vertical);
        Move(direction);
        /*Temporizador();*/
        var shouldShoot = Input.GetKeyDown(KeyCode.Space);
        if (shouldShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
    }
    private void ReceiveDamage (float damage)
    {
        health -= damage;
        var amIDead = health <= 0;

        if (amIDead)
        {
            health = 0;
            Debug.Log(message: "Die");
        }

    }

    private void ResetTimer()
    {
        timeToMoveLeft = timeToMove;
    }

   /* private void Temporizador()
    {
        timeToMoveLeft -= Time.deltaTime;
        if(timeToMoveLeft <= 0)
        {
            Move();
            ResetTimer();
        }
    }*/

    private void Move(Vector3 moveDirection)
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
