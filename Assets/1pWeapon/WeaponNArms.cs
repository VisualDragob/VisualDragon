using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponNArms : MonoBehaviour {

    public enum PlayerStates {init, stand, run, aim, runaim};
    Animation anim;
    public float AimSlow;

    public static class Player {
        static public PlayerStates state;
        
    }
    
    // Use this for initialization
    void Start () {
        Player.state = PlayerStates.init;
        anim = GetComponent<Animation>();
        //anim.Play("Aim");
	}
	
	// Update is called once per frame
	void Update () {

        switch (Player.state) {
            case PlayerStates.aim:
                anim.Play("Aim");
                Time.timeScale = 1 / AimSlow * 100;
                break;
            case PlayerStates.run:
                anim.Play("Run");
                Time.timeScale = 1;
                break;
            case PlayerStates.stand:
                anim.Play("Crouch2");
                break;


        }
 
	}
}
