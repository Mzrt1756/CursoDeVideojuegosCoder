using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemy : MonoBehaviour
{
    public string enemyName;
    public int health;
    public int attack;
    public int magicAttack;
    public int defense;
    public Vector3 direction;
    [SerializeField] private float speed;
    public Vector3 scale;
    [SerializeField] private double physicsFall;
    [SerializeField] private Vector3 myPosition;
    public bool fallingDamage;
    [SerializeField] private ScriptPlayer scriptPlayer;
    


    // Start is called before the first frame update
    void Start()
    {
        MagicAttack();
        enemyName = scriptPlayer.GetName();
        Debug.Log(message: scriptPlayer.GetName());
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            transform.position += direction*speed;
            if (transform.localScale.y > 0)
            {
                transform.localScale += scale;
            }
            
        }
       
    }

    public void MagicAttack()
    {
        scriptPlayer.health -= magicAttack;
    }
}
