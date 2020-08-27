using System.Collections;
using UnityEngine;

public class WebcamTexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}