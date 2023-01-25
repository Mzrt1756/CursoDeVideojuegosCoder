using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform characterToFollow;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 _offset;
    // Start is called before the first frame update

    private void Awake()
    {
        _offset = transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = characterToFollow.position + _offset;
    }
}
