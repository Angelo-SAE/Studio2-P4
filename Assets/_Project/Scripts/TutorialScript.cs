using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    public bool bellPressed;
    [SerializeField] private TMP_Text tutorialText;
    [SerializeField] private SubmitOrder submitOrderScript;
    [SerializeField] private string sceneName;
    private int tutorialSection;


    // Start is called before the first frame update
    void Start()
    {
      tutorialText.text = "Welcome, valued employee to MIX-UP LLC. As you are a new employee you are required to take the manditory smoothie training program.<br>To start the training click on the service bell.";
    }

    // Update is called once per frame
    void Update()
    {
      TutorialManager();
    }

    private void TutorialManager()
    {
      if(bellPressed && tutorialSection == 0)
      {
        Debug.Log("1");
        IncreaseTutorialSection();
      }
      if(tutorialSection == 1)
      {
        Debug.Log("2");
        tutorialText.text = "At MIX-UP you are required to take orders from customers and produce the required beverage.";
        IncreaseTutorialSection();
        Invoke("IncreaseTutorialSection", 10f);
      }
      if(submitOrderScript.correct > 0 && tutorialSection == 4)
      {
        Debug.Log("4");
        IncreaseTutorialSection();
        tutorialText.text = "Congrats on completing your first order. Although this was simple please keep in mind that they don't place their orders with as clear of a description.";
        Invoke("IncreaseTutorialSection", 15f);
      } else if(tutorialSection == 3)
      {
        Debug.Log("3");
        IncreaseTutorialSection();
        tutorialText.text = "Take a cup from the stack and fill the cup with the ingredients listed on the monitor. Once done place the smoothie on the tray and hit the service bell.";
      }
      if(tutorialSection == 6)
      {
        Debug.Log("5");
        tutorialText.text = "Good Luck.";
        IncreaseTutorialSection();
        Invoke("IncreaseTutorialSection", 0.3f);
      }
      if(tutorialSection == 8)
      {
        Debug.Log("6");
        SceneManager.LoadScene(sceneName);
      }
    }

    private void IncreaseTutorialSection()
    {
      tutorialSection++;
    }
}
