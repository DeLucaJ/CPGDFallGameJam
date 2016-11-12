using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    //singleton
    public static GameManager inst;

    void Awake()
    {
        inst = this;
    }

    public bool playerPaused;       //whether the game is paused

    // Use this for initialization
    void Start ()
    {
        playerPaused = false;
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
