
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour,IPointerUpHandler, IPointerDownHandler {

    [HideInInspector]
    public bool presionado;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        presionado = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        presionado = false;
    }
}
