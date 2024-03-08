using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayOrder : Orders
{
    [SerializeField] private GameObject orderTextObj, errorTextObj, correctTextObj;
    [SerializeField] private TMP_Text orderText, scoreText;
    [SerializeField] private bool tutorial;
    private int score;

    void Start()
    {
      if(tutorial)
      {
        currentOrder = new int[3];
        currentOrder[0] = 1;
        currentOrder[1] = 1;
        currentOrder[2] = 3;
        DisplayTutorialOrder();
      } else {
      GetNewOrder();
      }
    }

    private void DisplayTutorialOrder()
    {
      orderText.text = "Banana<br>Banana<br>Lemon";
    }

    private void DisplayCurrentOrder(string order)
    {
      orderText.text = order;
    }

    public void GetNewOrder()
    {
      if(!tutorial)
      {
        GetNextOrder();
        DisplayCurrentOrder(currentOrderText);
      } else {
        DisplayCurrentOrder("");
      }
    }

    public void IncreaseAndDisplayScore()
    {
      score++;
      scoreText.text = score.ToString();
    }

    //public void DecreaseAndDisplayScore()
    //{
    //  score--;
    //  scoreText.text = score.ToString();
    //}

    public void CorrectOrderDisplay()
    {
      orderTextObj.SetActive(false);
      correctTextObj.SetActive(true);
      Invoke("ReturnNormalOrder", 1f);
    }

    public void IncorrectOrderDisplay()
    {
      orderTextObj.SetActive(false);
      errorTextObj.SetActive(true);
      Invoke("ReturnNormalOrder", 1f);
    }

    private void ReturnNormalOrder()
    {
      errorTextObj.SetActive(false);
      correctTextObj.SetActive(false);
      orderTextObj.SetActive(true);
    }
}
