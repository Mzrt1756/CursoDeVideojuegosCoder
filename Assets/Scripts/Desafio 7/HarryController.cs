using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using Cursor = UnityEngine.Cursor;

public class HarryController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator harryAnimator;
    private static readonly int Speed = Animator.StringToHash("Speed");
    [SerializeField] private Camera m_camera;
    [SerializeField] private TMP_Text m_deathText;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private Vector3 harryShrinkScale;
    [SerializeField] private Vector3 harryOriginalScale;

    private void Start()
    {
        harryOriginalScale = transform.localScale;
        harryShrinkScale = harryOriginalScale / 10;
    }

    void Update()
    {
        Move(GetMovementInput());
        Rotate(GetRotationInput());
    }

    public void ReceiveDamage(float p_damage)
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            if (gameObject)
            {
                Debug.Log(message: "El Harry ha muerto.");
                m_deathText.gameObject.SetActive(true);
                Destroy(gameObject);
                
            }
        }
        else
        {
            currentHealth -= p_damage;
            m_deathText.gameObject.SetActive(false);
        }
    }

    public void ReceiveHealing(float p_healing)
    {
        if(currentHealth>=maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += p_healing;
        }
        
    }

    public void Shrinking()
    {
        if (transform.localScale == harryOriginalScale)
        {
            transform.localScale = harryShrinkScale;
        }
        else if (transform.localScale == harryShrinkScale)
        {
            transform.localScale = harryOriginalScale;
        }

    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Cursor.visible = !hasFocus;
        Cursor.lockState = hasFocus ? CursorLockMode.None : CursorLockMode.Confined;
    }
    private void Rotate(Vector2 p_scrollDelta)
    {
        transform.Rotate(Vector3.up, p_scrollDelta.x * rotationSpeed * Time.deltaTime, Space.Self);
    }

    private Vector2 GetRotationInput()
    {
        var l_mouseX = Input.GetAxis("Mouse X");
        var l_mouseY = Input.GetAxis("Mouse Y");
        return new Vector2(l_mouseX, l_mouseY);
    }

    private Vector3 GetMovementInput()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");
        return new Vector3(l_horizontal, 0, l_vertical).normalized;
    }

    private void Move(Vector3 p_inputMovement)
    {
        var transform1 = transform;
        transform1.position += (p_inputMovement.z * transform1.forward + p_inputMovement.x * transform1.right) *
                               (speed * Time.deltaTime);
        harryAnimator.SetFloat(Speed, p_inputMovement.magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(message:"Collision with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: "Collision with: " + other.gameObject.name);
        Debug.Log(message: "¿Has Shrinker Script? " + other.TryGetComponent<Shrinker>(out var exists));
    }
}