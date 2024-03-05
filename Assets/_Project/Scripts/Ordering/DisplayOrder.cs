using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayOrder : Orders
{

    [SerializeField] private TMP_Text orderText;

    void Start()
    {
      GetNewOrder();
    }

    private void DisplayCurrentOrder(int[] order)
    {
      orderText.text = order[0].ToString()+ "<br>" + order[1].ToString() + "<br>" + order[2].ToString();
    }

    public void GetNewOrder()
    {
      SelectRandomOrder();
      DisplayCurrentOrder(currentOrder);
    }
}
