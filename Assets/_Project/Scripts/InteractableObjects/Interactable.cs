using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private GameObject storedCup;

    public GameObject StoredCup
    {
      get => storedCup;
      set => storedCup = value;
    }
    public abstract void Interact0(GameObject obj);
    public abstract void Interact1(GameObject obj);
}
