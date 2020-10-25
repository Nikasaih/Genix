using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject newCanvas;
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
        gameObject.setActive(false);
        newCanvas.setActive(true);
    }
}