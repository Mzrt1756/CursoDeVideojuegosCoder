using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LisaStates
{
    Idle,
    Pursuit,
    RunAway
}
public class LisaController : MonoBehaviour
{

    /*[SerializeField] private string idle, pursuit, runAway;
    [SerializeField] private string currentState;*/
    [SerializeField] private LisaStates currentState;
    [SerializeField] private Transform chris;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 initialRotation;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private int pursuitDistance;


    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(initialRotation);
    }

    // Update is called once per frame
    void Update()
    {
        setCurrentState();
        LookAtPlayer();
    }

    private void setCurrentState()
    {
        switch (currentState)
        {
            case LisaStates.Idle:
                ExecuteIdle();
                break;
            case LisaStates.Pursuit:
                ExecutePursuit();
                break;
            case LisaStates.RunAway:
                ExecuteRunAway();
                break;
            default:
                Debug.Log(message: "current state is invalid");
                break;
        }
    }

    private void ExecuteIdle()
    {

    }

    private void ExecutePursuit()
    {
        var vectorToChris = chris.position - transform.position;
        var distance = vectorToChris.magnitude;
        LookAtPlayer();
        if (distance < pursuitDistance)
        {
            transform.position += Vector3.MoveTowards(transform.position, chris.position, Time.deltaTime * speed);
        }

        //transform.position += vectorToChris.normalized * (speed * Time.deltaTime);
    }

    private void ExecuteRunAway()
    {

    }

    private void LookAtPlayer()
    {

        //Metodo1
        //transform.LookAt(chris);
        //Metodo2
        var vectorToChris = chris.position - transform.position;
        var newRotation = Quaternion.LookRotation(vectorToChris);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed);


    }

}
