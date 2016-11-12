using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

[CreateAssetMenu(menuName = "Level")]
public class Level : ScriptableObject
{
    public Vector2 heavyStart;
    public Vector2 lightStart;

    public int levLindex;

    /// <summary>
    /// Loads the level's scene and spawns the player characters.
    /// </summary>
    public void loadLevel()
    {
        SceneManager.LoadScene(levLindex, LoadSceneMode.Single);

        //change these to corresponding characters
        GameObject hev = Instantiate(GameManager.inst.heavyPlayer, heavyStart, Quaternion.identity) as GameObject;
        GameObject lit = Instantiate(GameManager.inst.lightPlayer, lightStart, Quaternion.identity) as GameObject;

        //add behaviors?
    }
}
