using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIController : MonoBehaviour
{
    
    public GameObject PortalPicker;
    //public GameObject destinationInputFieldGameObject;
    //public InputField destinationInputField;
    //public string commandInput;
    private bool isPortalPickerDisplayed = false;
    private string sceneName;

    void Start()
    {
        PortalPicker.SetActive(false);
        //commandInput = destinationInputField.text;
        
    }

    void Update()
    {

        if (Input.GetKeyUp("/"))
        {
            if (!(isPortalPickerDisplayed))
            {
                DisplayPortalPicker();
            }
        }

        if (Input.GetKeyUp("return"))
        {
            if (isPortalPickerDisplayed)
            {
                HidePortalPicker();
            }
        }


        if (isPortalPickerDisplayed) {

            // Press the key associated with the stage to start coroutine

            //This is a nasty way to do it. I should be using switch statements instead. - DS

            if (Input.GetKeyDown("1"))
            {
                sceneName = "Scene1";
                // Use a coroutine to load Scene1 in the background
                StartCoroutine(BeginLoadSceneAsync());
                Debug.Log("Televorting to " + sceneName);

            }

            if (Input.GetKeyDown("2"))
            {
                sceneName = "Scene2";
                // Use a coroutine to load the Scene2 in the background
                StartCoroutine(BeginLoadSceneAsync());
                Debug.Log("Televorting to " + sceneName);
            }

            if (Input.GetKeyDown("3"))
            {
                sceneName = "Scene3";
                // Use a coroutine to load the Scene3 in the background
                StartCoroutine(BeginLoadSceneAsync());
                Debug.Log("Televorting to " + sceneName);
            }



        }

    }

    IEnumerator BeginLoadSceneAsync()
    {
        // Loads the Scene in the background as the current scene runs.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void DisplayPortalPicker() {
        Debug.Log("Portal Picker displayed.");
        isPortalPickerDisplayed = true;
        PortalPicker.SetActive(true);
        //destinationInputField.Select();
        //Debug.Log("Input field selected.");
    }

    public void HidePortalPicker()
    {
        Debug.Log("Portal Picker hidden.");
        isPortalPickerDisplayed = false;
        PortalPicker.SetActive(false);
    }


}






/* Add this to Update if we decide Text Input Method should be used.
 // Encountering a bug in which the InputField Select is not working consistently on subsequent display 
 // and hiding of destination bar. That is, after the first time the user hits / to display the bar and 
 // return to hide it, it is inconsistent whether they input field will be selected when they display it again. -DS 08/27/2020

 //return;
*/
