using UnityEngine;
using System.Collections;

public class Brawler : MonoBehaviour
{
    protected bool friendly;                //whether the brawler is on the player's side
    public int health;                      //brawler's current health
    protected int maxHeath;                 //brawler's maximum health
    protected int atkDam;                   //brawler's attack damage
    protected int fireRate;                 //time interval between brawler's attacks
    protected int fireTick;                 //time elapsed since last attack
    protected float projectSp;              //speed of projectile attacks (0 if melee)
    protected int atkDur;                   //attack duration
    public Attack attackType;               //brawler's designated attack prefab
    
    
    
    protected bool facingRight;             //brawler's direction

    // Use this for initialization
    void Start ()
    {
        fireTick = 0;
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
        float distance = 1f;

        distance = facingRight ? distance : -distance;                                      //reverse direction if facing left
        Vector2 strikeZone = new Vector2(transform.position.x + distance, transform.position.y);
        Attack atk = Instantiate(attackType, strikeZone, Quaternion.identity) as Attack;    //instantiate attack

        //set attack properties
        //NOTE: may end up being pre-determined by prefab instead
        atk.speed = projectSp;                                                              //projectile speed
        atk.damage = atkDam;                                                                //attack damage
        atk.duration = atkDur;                                                              //attack duration
        atk.friendly = friendly;                                                            //attack's team matches the user's
        Rigidbody2D atkBod = atk.gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;     //add rigidbody
    }

    void OnCollisionEnter(Collision col)
    {
        //get hit by attack
        Attack atk = col.gameObject.GetComponent<Attack>() as Attack;
        if (atk != null && (atk.friendly) != this.friendly)
        {
            health -= atk.damage;
            Destroy(col.gameObject);            //assumes each attack will only hit one enemy
            if (health <= 0)
                die();
        }
    }

    /// <summary>
    /// An enemy is destroyed, a dying PC means game over.
    /// </summary>
    protected void die()
    {
        if (!friendly)
        {
            Destroy(gameObject);    //enemy dies
        }
        //else, game over
    }
}
