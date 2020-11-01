using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject oldCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeCanvas(GameObject newCanvas)
    {
        oldCanvas.SetActive(false);
        newCanvas.SetActive(true);
    }
}