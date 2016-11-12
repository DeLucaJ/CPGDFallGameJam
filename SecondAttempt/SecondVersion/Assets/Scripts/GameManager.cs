using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    //singleton
    public static GameManager inst;

    void Awake()
    {
        inst = this;
    }

    //selected character prefabs
    public GameObject heavyPlayer;
    public GameObject lightPlayer;

    //game levels
    public int level;
    public Level[] levels;

    //game screens
    public Scene startScreen;       //start menu
    public Scene goScreen;          //game over screen
    public Scene pauseScreen;       //pause screen

    //public bool playerPaused;       //whether the game is paused

    // Use this for initialization
    void Start ()
    {
        //playerPaused = false;
    }

    public void loadLv(int lv)
    {
        levels[lv].loadLevel();
    }
    
    // Update is called once per frame
    void Update ()
    {
        //check pause
    }


    public void gameOver()
    {

    }
}
