using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupDispenser : Interactable
{

    [SerializeField] private GameObject cup;

    public override void Interact0(GameObject obj)
    {
      //does nothing
    }

    public override void Interact1(GameObject obj)
    {
      GameObject curCup = Instantiate(cup);
      curCup.transform.parent = obj.transform;
      curCup.transform.localPosition = Vector3.zero;
    }
}
