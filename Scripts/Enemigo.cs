using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent enemigo;
    public Transform dragon1;
    Animator anim,anim2;
    protected Joybutton2 joybutton2;
    private bool bandera;

    // Use this for initialization
    void Start () {
        joybutton2 = FindObjectOfType<Joybutton2>();
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim2 = dragon1.GetComponent<Animator>();
        enemigo.nextPosition=new Vector3(0.25f, 0.1f, 0);
        bandera = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (joybutton2.presionado)
        {
            if (bandera == true)
            {
                bandera = false;
            }
            else
            {
                bandera = true;
            }
            
        }
        if (bandera == true)
        {
            enemigo.destination = dragon1.position;
        }
        
        if (enemigo.destination == dragon1.position)
        {
            anim.SetTrigger("ataquenegro");
            anim2.SetTrigger("golpe");
            enemigo.nextPosition = new Vector3(0.25f, 0.1f, 0);
            bandera = false;
        }            

	}
}
