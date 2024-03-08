using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orders : MonoBehaviour
{
    private int[][] listOfOrders;
    private string[] listOfOrdersText;
    protected int[] currentOrder;
    protected string currentOrderText;
    private int orderNumber;

    public int[] CurrentOrder
    {
      get => currentOrder;
      set => currentOrder = value;
    }

    void Awake()
    {
      listOfOrders = new int[11][];
      listOfOrdersText = new string[11];
      CreateOrderList();
    }

    //protected void SelectRandomOrder()
    //{
    //  currentOrder = listOfOrders[Random.Range(1, 50)];
    //}

    protected void GetNextOrder()
    {
      if(orderNumber < 11)
      {
        currentOrder = listOfOrders[orderNumber];
        currentOrderText = listOfOrdersText[orderNumber];
      }
      CheckForWin();
      orderNumber++;
    }

    private void CheckForWin()
    {
      if(orderNumber >= 11)
      {
        SceneManager.LoadScene("WinScene");
      }
    }

    private void CreateOrderList()
    {
      //order numbers
      listOfOrders[0] = new int[] {(int)DrinkFlavors.Banana, (int)DrinkFlavors.Banana, (int)DrinkFlavors.Banana};
      listOfOrders[1] = new int[] {(int)DrinkFlavors.Lemon, (int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Strawberry};
      listOfOrders[2] = new int[] {(int)DrinkFlavors.Watermelon, (int)DrinkFlavors.Strawberry};
      listOfOrders[3] = new int[] {(int)DrinkFlavors.Lemon, (int)DrinkFlavors.Orange, (int)DrinkFlavors.Strawberry};
      listOfOrders[4] = new int[] {(int)DrinkFlavors.Lemon, (int)DrinkFlavors.Banana};
      listOfOrders[5] = new int[] {(int)DrinkFlavors.Watermelon, (int)DrinkFlavors.Orange, (int)DrinkFlavors.Lemon};
      listOfOrders[6] = new int[] {(int)DrinkFlavors.Watermelon, (int)DrinkFlavors.Banana};
      listOfOrders[7] = new int[] {(int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Blueberry};
      listOfOrders[8] = new int[] {(int)DrinkFlavors.Lemon, (int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Strawberry};
      listOfOrders[9] = new int[] {(int)DrinkFlavors.Lemon, (int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Banana};
      listOfOrders[10] = new int[] {(int)DrinkFlavors.Watermelon, (int)DrinkFlavors.Blueberry, (int)DrinkFlavors.Strawberry};

      //order text
      listOfOrdersText[0] = "Can I order a triple banana smoothie";
      listOfOrdersText[1] = "Can I order a lemon, blueberry and strawberry mix";
      listOfOrdersText[2] = "I want a blood smoothie mix with two fruits of the same color";
      listOfOrdersText[3] = "I want a smoothie mix of three of the most sour fruits";
      listOfOrdersText[4] = "I want a smoothie mix of the most sweet and the most sour fruit";
      listOfOrdersText[5] = "Give me a smoothie made of three different big round fruits";
      listOfOrdersText[6] = "Give me a smoothie with a sweet red fruit mixed with a non sour yellow fruit";
      listOfOrdersText[7] = "GIVE smOoThie wITh SmALl FrUITS oF MaNY";
      listOfOrdersText[8] = "SMOOTHIE WITH THREE DIFFERENT NOT SWEET";
      listOfOrdersText[9] = "GIv$ SM*&TH!E Fr#i! wI%@ n0 R&D oR 0R@nGe";
      listOfOrdersText[10] = "NOW SMOOTHIE WITH $*&#@*%$#! AND #)*%*(&#% wI!h THR#E S0uR M0s#";
    }
}
