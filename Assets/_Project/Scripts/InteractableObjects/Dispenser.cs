using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : Interactable
{

    [SerializeField] private GameObject cupHolder;
    [SerializeField] private DrinkFlavors drinkFlavor;

    public override void Interact0(GameObject obj)
    {
      storedCup = cupHolder.GetComponent<Interactable>().StoredCup;
      if(storedCup is not null)
      {
        storedCup.GetComponent<Cup>().AddDrinkToMix((int)drinkFlavor);
      }
    }

    public override void Interact1(GameObject obj)
    {
      //empty
    }
}
