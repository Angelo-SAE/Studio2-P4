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

    private void DisplayCurrentOrder(int[] order)
    {
      orderText.text = order[0].ToString()+ "<br>" + order[1].ToString() + "<br>" + order[2].ToString();
    }

    public void GetNewOrder()
    {
      SelectRandomOrder();
      DisplayCurrentOrder(currentOrder);
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
