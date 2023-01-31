using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    private float cooldownTimer;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter (Collider shrinkArea)
    {
        if (cooldownTimer <= 0 && shrinkArea.TryGetComponent<HarryController>(out var l_harryController))
        {
            cooldownTimer = 2f;
            l_harryController.Shrinking();
        }
    }

}
