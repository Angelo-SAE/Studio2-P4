using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : Interactable
{
    public int flavor;

    public override void Interact0(GameObject obj)
    {
      transform.parent = obj.transform;
      transform.localPosition = Vector3.zero;
    }

    public override void Interact1(GameObject obj)
    {
      Debug.Log("1");
    }
}
