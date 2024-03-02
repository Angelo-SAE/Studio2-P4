using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupHolder : Interactable
{
    public override void Interact0(GameObject obj)
    {
      StoredCup.transform.parent = obj.transform;
      StoredCup.transform.localPosition = Vector3.zero;
      StoredCup = null;
    }

    public override void Interact1(GameObject obj)
    {
      obj.transform.parent = transform;
      obj.transform.localPosition = Vector3.zero;
      StoredCup = obj;
    }
}
