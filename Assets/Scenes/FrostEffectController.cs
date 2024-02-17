using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrostEffectController : MonoBehaviour
{
    private FrostEffect frostEffect;
    private float currentFrostValue;
    // Start is called before the first frame update
    void Start()
    {
        frostEffect = GetComponent<FrostEffect>();
        InitialFrostAmount();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentFrostValue > 0)
        {
            currentFrostValue -= Time.deltaTime / 20;
            UpdateFrostAmount(0);
            if(currentFrostValue <= 0)
            {
                InitialFrostAmount();
            }

        }
    }

    public void UpdateFrostAmount(float amount)
    {
        currentFrostValue += amount;
        frostEffect.FrostAmount = currentFrostValue;
    }

    public void InitialFrostAmount()
    {
        currentFrostValue = 0;
        frostEffect.FrostAmount = currentFrostValue;
    }
}
