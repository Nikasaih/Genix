using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Ready : MonoBehaviour
{
    public Button Btn_Ready;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = Btn_Ready.GetComponent<Button>();
        btn.onClick.AddListener(//Set player 1 ready);
    }

    // Update is called once per frame
    void Update()
    {
        if (XRNodeState.tracked == true)
        {
            // Set player 2 ready
        }
    }


}
