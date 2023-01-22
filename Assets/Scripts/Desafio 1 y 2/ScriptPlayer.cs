using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    [SerializeField] private string playerName;
    [SerializeField] private int userNumber;
    public int health;
    public int attack;
    public int defense;
    public Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private double physicsFall;
    [SerializeField] private Vector3 myPosition;
    public int mana;
    public int heal;
    public bool fallingDamage;
    private int m_increaseAttack = 10;
    [SerializeField] private ScriptEnemy scriptEnemy;
    

    private void Awake()
    {
        SetName("SrAlpha");
    }

    void Start()
    {
        

        if (m_increaseAttack != 0 && mana >0)
        {
            mana -= m_increaseAttack;
            attack += m_increaseAttack;
            return;
        }
       
        
    }

    void Update()
    {
        if (scriptEnemy.health >= 0)
        {
            scriptEnemy.health -= attack - scriptEnemy.defense;
        }
        if (mana > 0)
        {
            mana -= heal;
            Heal();
        }
    }

    public int Heal()
    {
        health += heal;
        return health;
    }

    public string GetName()
    {
        return playerName;
    }

    private void SetName(string newName)
    {
        playerName = newName;
    }

    private void SetName (string newName, int userNumber)
    {
        playerName = newName + userNumber;
    }
}
