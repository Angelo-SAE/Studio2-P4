using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitOrder : Interactable
{

    [SerializeField] private GameObject cupHolder, orderScreen;
    private DisplayOrder orderScript;
    [SerializeField] private int correct, incorrect;

    void Awake()
    {
      orderScript = orderScreen.GetComponent<DisplayOrder>();
    }

    public override void Interact0(GameObject obj)
    {
      storedCup = cupHolder.GetComponent<Interactable>().StoredCup;
      if(storedCup is not null)
      {
        if(storedCup.GetComponent<Cup>().CheckDrinkMix(orderScript.CurrentOrder))
        {
          correct++;
          Destroy(storedCup);
          orderScript.GetNewOrder();
          orderScript.IncreaseAndDisplayScore();
        } else {
          incorrect++;
          orderScript.DecreaseAndDisplayScore();
          orderScript.IncorrectOrderDisplay();
          Destroy(storedCup);
        }
      }    }

    public override void Interact1(GameObject obj)
    {
      //does nothing
    }
}
