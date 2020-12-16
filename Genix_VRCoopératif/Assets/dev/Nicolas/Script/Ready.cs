using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class Ready : MonoBehaviour
{

    public Button P1_Status_Object;
    public Button P2_Status_Object;

    public Sprite OffSpriteNain;
    public Sprite OnSpriteNain;

    public Sprite OffSpriteGeant;
    public Sprite OnSpriteGeant;

    public bool P1_Status = false;
    public bool P2_Status = false;

    public Text timerLabel;
    private float time = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        P1_Status_Object.image.sprite = OffSpriteNain;
        P2_Status_Object.image.sprite = OffSpriteGeant;
        timerLabel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (P1_Status)
            P1_Status_Object.image.sprite = OnSpriteNain;
        else
            P1_Status_Object.image.sprite = OffSpriteNain;


        if (P2_Status)
            P2_Status_Object.image.sprite = OnSpriteGeant;
        else
            P2_Status_Object.image.sprite = OffSpriteGeant;

        if(P1_Status && P2_Status)
        {
            timerLabel.gameObject.SetActive(true);
            if (time > 0f)
            {
                time -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene(0);
            }

            

            var seconds = time % 60;//Use the euclidean division for the seconds.

            //update the label value
            timerLabel.text = string.Format("{0:00}", seconds);

            
        }
        else
        {
            timerLabel.gameObject.SetActive(false);
            time = 5.0f;
        }
        
    }

    public void ChangePlayerStatus(int playerStatus)
    {
        if (playerStatus == 1)
            if (P1_Status)
                P1_Status = false;
            else
                P1_Status = true;

        if (playerStatus == 2)
            if (P2_Status)
                P2_Status = false;
            else
                P2_Status = true;
    }

    
}
