using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    public GameObject destinationInputFieldGameObject;
    public InputField destinationInputField;
    public string commandInput;
    private bool isDestinationBarDisplayed = false;

    // Start is called before the first frame update
    void Start()
    {
        destinationInputFieldGameObject.SetActive(false);
        commandInput = destinationInputField.text;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("/"))
        {
            if (!(isDestinationBarDisplayed))
            {
                DisplayDestinationBar();
            }
        }

        if (Input.GetKeyUp("return"))
        {
            if (isDestinationBarDisplayed)
            {
                HideDestinationBar();
            }
        } //return;
    }

    // Encountering a bug in which the InputField Select is not working consistently on subsequent display 
    // and hiding of destination bar. That is, after the first time the user hits / to display the bar and 
    // return to hide it, it is inconsistent whether they input field will be selected when they display it again. -DS 08/27/2020

    public void DisplayDestinationBar() {
        Debug.Log("Destination bar displayed.");
        isDestinationBarDisplayed = true;
        destinationInputFieldGameObject.SetActive(true);
        destinationInputField.Select();
        Debug.Log("Input field selected.");
    }

    public void HideDestinationBar()
    {
        Debug.Log("Destination bar hidden.");
        isDestinationBarDisplayed = false;
        destinationInputFieldGameObject.SetActive(false);
    }

    public void PrintCommandInput() {
        Debug.Log("Sent message: " + commandInput);
    }

    public void GoToNewDestination() {
        commandInput = destinationInputField.text;
        Debug.Log("Televorting to " + commandInput);                  // Find a scene by name or tag that the user inputs. Load that scene asynchronously.
    }



}
