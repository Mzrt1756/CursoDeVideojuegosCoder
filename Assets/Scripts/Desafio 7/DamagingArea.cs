using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingArea : MonoBehaviour
{
    [SerializeField] private float damagingAmount;
    [SerializeField] private float damageTime;
    private float _currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider damagingArea)
    {
        if (_currentTime <= Time.time && damagingArea.TryGetComponent<HarryController>(out var l_harryController))
        {
            _currentTime = Time.time + damageTime;
            l_harryController.ReceiveDamage(damagingAmount * Time.fixedDeltaTime);
        }

    }
}
