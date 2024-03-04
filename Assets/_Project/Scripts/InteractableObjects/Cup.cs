using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : Interactable
{

    private int[] mix;
    private int mixCount;

    void Awake()
    {
      mix = new int[3];
      mix[0] = 0;
      mix[1] = 0;
      mix[2] = 0;
    }

    public override void Interact0(GameObject obj)
    {
      //does nothing
    }

    public override void Interact1(GameObject obj)
    {
      transform.parent = obj.transform;
      transform.localPosition = Vector3.zero;
    }

    public void AddDrinkToMix(int drinkNumber)
    {
      if(mixCount < mix.Length)
      {
        mix[mixCount] = drinkNumber;
        Debug.Log(mix[0]);
        Debug.Log(mix[1]);
        Debug.Log(mix[2]);
        mixCount++;
      }

    }

    private bool CheckDrinkMix(int[] order)
    {
      for(int a = 0; a < order.Length; a++)
      {
        if(mix[a] != order[a])
        {
          return false;
          DestroyCup();
        }
      }
      return true;
    }

    public void DestroyCup()
    {
      Destroy(gameObject);
    }
}
