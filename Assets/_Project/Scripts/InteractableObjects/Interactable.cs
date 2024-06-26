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
  Banana = 1,
  Blueberry = 2,
  Lemon = 3,
  Strawberry = 4,
  Orange = 5,
  Watermelon = 6
}
