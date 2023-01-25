using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera firstCamera;
    [SerializeField] private CinemachineVirtualCamera secondCamera;
    [SerializeField] private CinemachineVirtualCamera thirdCamera;
    [SerializeField] private CinemachineVirtualCamera shoulderCamera;
    [SerializeField] private CinemachineVirtualCamera thirdPersonCamera;
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
            TurnOnCamera(firstCamera, secondCamera, thirdCamera, shoulderCamera, thirdPersonCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            TurnOnCamera(secondCamera, firstCamera, thirdCamera, shoulderCamera, thirdPersonCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            TurnOnCamera(thirdCamera, firstCamera, secondCamera, shoulderCamera, thirdPersonCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            TurnOnCamera(shoulderCamera, firstCamera, secondCamera, thirdCamera, thirdPersonCamera);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            TurnOnCamera(thirdPersonCamera, firstCamera, secondCamera, thirdCamera, shoulderCamera);
        }
    }

    /*private void LateUpdate()
    {
        transform.position = characterToFollow.position + _offset;
    }*/
    private void TurnOnCamera(CinemachineVirtualCamera camToTurnOn, CinemachineVirtualCamera otherCamera1, CinemachineVirtualCamera otherCamera2, CinemachineVirtualCamera otherCamera3, CinemachineVirtualCamera otherCamera4)
    {
        //Opcion 1: Apagar y prender el GO
        camToTurnOn.gameObject.SetActive(true);
        otherCamera1.gameObject.SetActive(false);
        otherCamera2.gameObject.SetActive(false);
        otherCamera3.gameObject.SetActive(false);
        otherCamera4.gameObject.SetActive(false);

        //Opcion 2: Apagar y prender el componente;

    }
}
