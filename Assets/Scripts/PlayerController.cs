using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //1. Declaración de variables
    [Range(1, 10)] public float velocidad; //Velocidad del jugador
    Rigidbody2D rb2d;
    SpriteRenderer spRd;

    void Start () {

        //2. Capturo y asocio los componentes Rigidbody2D y Sprite Renderer del Jugador
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();

    }
	
    void FixedUpdate () {
        float movimientoH = Input.GetAxisRaw("Horizontal");
        float movimientoV = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector2(movimientoV * velocidad, rb2d.velocity.y);
        rb2d.velocity = new Vector3(movimientoH * velocidad, rb2d.velocity.x);

    }
}

