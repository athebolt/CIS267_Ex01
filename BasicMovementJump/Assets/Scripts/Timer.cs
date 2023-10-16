using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;
    private TMP_Text guiTime;
    //this is assigned via unity editor
    public GameObject gameManager;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
        time = 5;
        guiTime = GetComponent<TMP_Text>();
        updateGUITime();
    }

    // Update is called once per frame
    void Update()
    {
        timerTick();
    }

    public void timerTick()
    {
        time -= Time.deltaTime;

        updateGUITime();

        if(timeUp())
        {
            gm.setGameOver(true);

            time = 0;
            updateGUITime();
        }
    }

    public void updateGUITime()
    {
        guiTime.text = "Time: " + (int)time;
    }

    public bool timeUp()
    {
        if (time <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
