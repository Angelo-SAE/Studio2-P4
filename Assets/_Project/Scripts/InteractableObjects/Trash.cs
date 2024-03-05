using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : Interactable
{
    public override void Interact0(GameObject obj)
    {
      Destroy(obj);
    }

    public override void Interact1(GameObject obj)
    {
      //does nothing
    }
}
