using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : Interactable
{
    [SerializeField] private GameObject fluid;
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
        mixCount++;
        AddFluid();
      }
    }

    private void AddFluid()
    {
      if(mixCount == mix.Length) fluid.SetActive(true);
    }

    public bool CheckDrinkMix(int[] order)
    {
      for(int a = 0; a < order.Length; a++)
      {
        for(int b = 0; b < mix.Length; b++)
        {
          if(mix[b] == order[a])
          {
            mix[b] = 0;
            break;
          }
          if(b == mix.Length - 1)
          {
            return false;
          }
        }
      }
      return true;
    }

    public void DestroyCup()
    {
      Destroy(gameObject);
    }
}
