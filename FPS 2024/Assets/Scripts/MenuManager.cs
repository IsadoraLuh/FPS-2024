using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour

{
    // Declara uma instancia  estatica da classe network   public static NetworkManager instance;
    public static MenuManager instance;

    private void Awake() // metodo chamado quando o script é inicializado
    {
        if (instance == null)
        { // verifica se a instancia é nula
            instance = this; // define a instancia para este objeto
            
        }
        else if (instance != this)
        {
            Destroy(gameObject);// destroi o objeto se ja houve uma instancia existente
        }
    }
    private void Connected()
    {
        
    }

}


