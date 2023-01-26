using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera firstCamera;
    [SerializeField] private CinemachineVirtualCamera secondCamera;
    [SerializeField] private CinemachineVirtualCamera thirdCamera;
    /*[SerializeField] private Transform characterToFollow;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 _offset;*/
    // Start is called before the first frame update

    private void Awake()
    {
        /*_offset = transform.position;*/
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            TurnOnCamera(firstCamera, secondCamera, thirdCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            TurnOnCamera(secondCamera, firstCamera, thirdCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            TurnOnCamera(thirdCamera, firstCamera, secondCamera);
        }
    }

    /*private void LateUpdate()
    {
        transform.position = characterToFollow.position + _offset;
    }*/
    private void TurnOnCamera(CinemachineVirtualCamera camToTurnOn, CinemachineVirtualCamera otherCamera1, CinemachineVirtualCamera otherCamera2)
    {
        //Opcion 1: Apagar y prender el GO
        camToTurnOn.gameObject.SetActive(true);
        otherCamera1.gameObject.SetActive(false);
        otherCamera2.gameObject.SetActive(false);
    }
}
