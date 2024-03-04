using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    protected GameObject storedCup;

    public GameObject StoredCup
    {
      get => storedCup;
      set => storedCup = value;
    }
    public abstract void Interact0(GameObject obj);
    public abstract void Interact1(GameObject obj);
}

public enum DrinkFlavors
{
  FirstFlavor = 1,
  SecondFlavor = 2,
  ThirdFlavor = 3,
  FourthFlavor = 4,
  FifthFlavor = 5
}
