using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FuelControl : MonoBehaviour
{
    public static FuelControl instance;

    [SerializeField] private Image fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float fuelDrainSpeed = 1f;
    [SerializeField] private float maxFuelAmount = 100f;

    private float currentFuelAmount;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentFuelAmount = maxFuelAmount;
        UpdateUI();
    }

    private void Update()
    {
        currentFuelAmount -= Time.deltaTime * fuelDrainSpeed;
        UpdateUI();
    }

    private void UpdateUI()
    {
        fuelImage.fillAmount = (currentFuelAmount / maxFuelAmount); 
    }
}
