using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject ball;
    public Transform shootingPosition1;
    public Transform shootingPosition2;
    public Transform shootingPosition3;
    public Transform shootingPosition4;
    private KeyCode shootOneBullet = KeyCode.Space;
    private KeyCode shootTwoBullets = KeyCode.J;
    private KeyCode shootThreeBullets = KeyCode.K;
    private KeyCode shootFourBullets = KeyCode.L;


    private void Update()
    {
        if (Input.GetKeyDown(shootOneBullet))
        {
            DisparoUno();
        }
        else if (Input.GetKeyDown(shootTwoBullets))
        {
            DisparoDos();
        }
        else if (Input.GetKeyDown(shootThreeBullets))
        {
            DisparoTres();
        }
        else if (Input.GetKeyDown(shootFourBullets))
        {
            DisparoCuatro();
        }

    }

    private void DisparoUno()
    {
        Instantiate(ball,shootingPosition1);
    }
    private void DisparoDos()
    {
        Instantiate(ball, shootingPosition1);
        Instantiate(ball, shootingPosition2);
    }
    private void DisparoTres()
    {
        Instantiate(ball, shootingPosition1);
        Instantiate(ball, shootingPosition2);
        Instantiate(ball, shootingPosition3);
    }
    private void DisparoCuatro()
    {
        Instantiate(ball, shootingPosition1);
        Instantiate(ball, shootingPosition2);
        Instantiate(ball, shootingPosition3);
        Instantiate(ball, shootingPosition4);
    }



}
