using UnityEngine;
using System.Collections;

public abstract class Brawler : MonoBehaviour
{
    public int health;          //brawler's current health
    private int maxHeath;       //brawler's maximum health
    private int atkDam;         //brawler's attack damage
    
    
    
    public bool facingRight;    //brawler's direction

    // Use this for initialization
    void Start ()
    {
    
    }
	
    // Update is called once per frame
    void FixedUpdate ()
    {
        //movement
        //attack
    }

    /// <summary>
    /// Creates an attack in front of the battler.
    /// </summary>
    public void attack()
    {

    }
}
