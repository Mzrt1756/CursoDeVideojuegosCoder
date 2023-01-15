using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBomb : MonoBehaviour
{
    public string bombName;
    public Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private int attack;
    [SerializeField] private double physicsFall;
    [SerializeField] private Vector3 myPosition;
    [SerializeField] private ScriptPlane scriptPlane;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < myPosition.y )
        {
            scriptPlane.health = 0;
        }
        else
        {
            transform.position += direction*speed;
        };

    }
}
