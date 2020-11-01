using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessParentReady : MonoBehaviour
{

    public bool isReady;
    // Start is called before the first frame update
    void Start()
    {
        Ready myParent = transform.parent.GetComponent<Ready>();
        isReady = myParent.P1_Status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AccessSetReady()
    {
        transform.parent.GetComponent<Ready>().P1_Status = true;
    }
}
