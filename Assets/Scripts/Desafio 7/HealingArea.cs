using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingArea : MonoBehaviour
{
    [SerializeField] private float healingAmount;
    [SerializeField] private float timeToHeal;
    private float _currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider healingArea)
    {
        if(_currentTime <= Time.time && healingArea.TryGetComponent<HarryController>(out var l_harryController))
        {
            _currentTime = Time.time + timeToHeal;
            l_harryController.ReceiveHealing(healingAmount * Time.fixedDeltaTime);
        }
        
    }
}
