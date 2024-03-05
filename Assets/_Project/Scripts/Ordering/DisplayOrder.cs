using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayOrder : Orders
{
    [SerializeField] private GameObject orderTextObj, errorTextObj;
    [SerializeField] private TMP_Text orderText, scoreText;
    private int score;

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

    public void IncreaseAndDisplayScore()
    {
      score++;
      scoreText.text = score.ToString();
    }

    public void DecreaseAndDisplayScore()
    {
      score--;
      scoreText.text = score.ToString();
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
      orderTextObj.SetActive(true);
    }
}
