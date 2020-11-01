using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Ready : MonoBehaviour
{
    public Button Btn_Ready;

    public Image P1_Status_Object;
    public GameObject P2_Status_Object;

    public bool P1_Status = true;
    public bool P2_Status = false;
    // Start is called before the first frame update
    void Start()
    {
        //Button btn = Btn_Ready.GetComponent<Button>();
        //btn.onClick.AddListener(//Set player 1 ready);
    }

    // Update is called once per frame
    void Update()
    {
        if (P1_Status)
        {
            P1_Status_Object.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }

        //if (XRNodeState.tracked == true)
        {
            // Set player 2 ready
        }
    }

}
