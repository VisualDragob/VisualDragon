using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponNArms : MonoBehaviour {

    public enum PlayerStates { aim, walk, stand, init, run, fastrun };
    Animation anim;
    public int a;
    public static class Player {
        static public PlayerStates state;
        
    }
    
    // Use this for initialization
    void Start () {
        Player.state = PlayerStates.init;
        anim = GetComponent<Animation>();
        anim.Play("Idle");
	}
	
	// Update is called once per frame
	void Update () {
        //switch(p1.state)
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {

            anim.Play("Crouch2");
        }
	}
}
