using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orders : MonoBehaviour
{
    [SerializeField] protected int[][] listOfOrders;
    protected int[] currentOrder;

    public int[] CurrentOrder
    {
      get => currentOrder;
      set => currentOrder = value;
    }

    void Awake()
    {
      listOfOrders = new int[50][];
      CreateOrderList();
    }

    protected void SelectRandomOrder()
    {
      currentOrder = listOfOrders[Random.Range(1, 50)];
    }

    private void CreateOrderList()
    {
      for(int a = 0; a < 50; a++)
      {
        listOfOrders[a] = new int[] {Random.Range(1, 6 + 1), Random.Range(1, 6 + 1), Random.Range(1, 6 + 1)};
      }
    }
}
