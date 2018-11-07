using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    protected Joystick joystick;
    protected Joybutton joybutton;
    protected Joybutton2 joybutton2;
    protected Salir bsalir;

    Animator anim,anime;
    public Transform enemigo;

	// Use this for initialization
	void Start () {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
        joybutton2 = FindObjectOfType<Joybutton2>();
        bsalir = FindObjectOfType<Salir>();

        anim = GetComponent<Animator>();
        anime= enemigo.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(-(joystick.Horizontal * 5f), 
            rigidbody.velocity.y, 
            -(joystick.Vertical * 5f));

        if(joybutton.presionado)
        {
            anim.SetTrigger("ataque");
            anime.SetTrigger("muerte");
        }

        if (bsalir.presionado)
        {
            Application.Quit();
        }
    }
}
