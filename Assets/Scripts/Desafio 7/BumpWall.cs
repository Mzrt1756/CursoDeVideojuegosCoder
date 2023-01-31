using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private Vector3 newPosition;
    [SerializeField] private Vector3 newRotation;
    private float timeOfCollision;
    private float timeRCollision = 2f;


    public Vector3 GetPosition()
    {
        return newPosition = new Vector3 (Random.Range(-10,11),0, Random.Range(-10, 11));

    }

    public Vector3 GetRotation()
    {
        return newRotation = new Vector3(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
    }

    private void OnCollisionEnter(Collision bumpWall)
    {
        timeOfCollision = 0f;
        Debug.Log("Collision Starts");
    }
    private void OnCollisionStay(Collision bumpWall)
    {
        if (timeOfCollision<timeRCollision)
        {
            timeOfCollision += Time.deltaTime;
            Debug.Log("Not enough collision.");
        }
        else
        {
            Debug.Log("Enough collision.");
            GetPosition();
            GetRotation();
            transform.position = newPosition;
            transform.Rotate(newRotation);

        }

    }
        

}
