using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupHolder : Interactable
{
    public override void Interact0(GameObject obj)
    {
      obj.transform.parent = transform;
      obj.transform.localPosition = Vector3.zero;
      storedCup = obj;
    }

    public override void Interact1(GameObject obj)
    {
      if(storedCup is not null)
      {
        storedCup.transform.parent = obj.transform;
        storedCup.transform.localPosition = Vector3.zero;
        storedCup = null;
      }
    }
}
