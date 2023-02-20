using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   public void Salir()
   {
      Application.Quit();
      Debug.Log("El juego se esta cerrando");
   } 
}
