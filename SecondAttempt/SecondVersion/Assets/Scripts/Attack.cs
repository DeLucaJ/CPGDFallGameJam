using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    public bool friendly;   //true if created by a PC Brawler
    public float speed;     //attack's lateral movement speed, 0 if ranged
    public int damage;      //the strength of the attack
    public int duration;    //how long the attack is supposed to exist
    private int elapsed;    //how long the attack has existed

	// Use this for initialization
	void Start ()
    {
        elapsed = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //existance tick
        if (++elapsed >= duration)
            Destroy(gameObject);
        //check collision
        //move
	}
}
