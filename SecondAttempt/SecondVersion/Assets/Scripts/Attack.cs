using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    public bool ranged;    //determines if the attack will move from its starting position
    public int damage;     //the strength of the attack
    public int duration;   //how long the attack is supposed to exist
    private int elapsed;    //how long the attack has existed

	// Use this for initialization
	void Start ()
    {
        elapsed = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
	    //check collision
        //move
	}
}
