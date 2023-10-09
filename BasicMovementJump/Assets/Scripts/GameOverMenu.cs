using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //drag and drop connection through unity
    public GameObject gameManager;
    public GameObject gameOverMenu;
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        //get the empty game object "gameManager" script and set it equal to gm
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if game is over, show game over menu
        if(gm.getGameOver() == true)
        {
            //showGameOverMenu();
            gameOverMenu.SetActive(true);
        }
    }

    public void showGameOverMenu()
    {
        //shows game over menu
        gameOverMenu.SetActive(true);
    }

    public void exitGame()
    {
        //exits game
        Application.Quit();
    }

    public void restartGame()
    {
        gm.setGameOver(false);

        //make the menu invisible
        gameOverMenu.SetActive(false);

        //load the game scene
        SceneManager.LoadScene("SampleScene");
    }
}
