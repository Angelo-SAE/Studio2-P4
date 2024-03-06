using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : Interactable
{

    [SerializeField] private GameObject cupHolder;
    [SerializeField] private DrinkFlavors drinkFlavor;
    [SerializeField] private Material buttonMat;
    private bool coolDown;

    public override void Interact0(GameObject obj)
    {
      storedCup = cupHolder.GetComponent<Interactable>().StoredCup;
      if(storedCup is not null && !coolDown)
      {
        cupHolder.GetComponent<CupHolder>().cantTakeCup = true;
        storedCup.GetComponent<Cup>().AddDrinkToMix((int)drinkFlavor);
        coolDown = true;
        ChangeMaterialColor(Color.red);
        Invoke("CoolDownReset", 2f);

      }
    }

    public override void Interact1(GameObject obj)
    {
      //empty
    }

    private void ChangeMaterialColor(Color color)
    {
      buttonMat.color = color;
    }

    private void CoolDownReset()
    {
      coolDown = false;
      ChangeMaterialColor(Color.green);
      cupHolder.GetComponent<CupHolder>().cantTakeCup = false;
    }
}
