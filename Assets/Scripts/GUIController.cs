using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    public GameObject destinationInputFieldGameObject;
    public InputField destinationInputField;
    public string commandInput;

    // Start is called before the first frame update
    void Start()
    {
        destinationInputFieldGameObject.SetActive(false);
        //commandInput = destinationInputField.text;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("/")) {
            DisplayDestinationBar();
        }
    }

    public void DisplayDestinationBar() {
        Debug.Log("Destination bar displayed.");
        destinationInputFieldGameObject.SetActive(true);
        destinationInputField.Select();
        Debug.Log("Input field selected.");
    }

    public void PrintCommandInput() {
        Debug.Log("Sent message: " + commandInput);
    }

    public void GoToNewDestination() {
        commandInput = destinationInputField.text;
        Debug.Log("Televorting to " + commandInput);                  // Find a scene by name or tag that the user inputs. Load that scene asynchronously.
    }



}
