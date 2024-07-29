using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks

    
{
    // Declara uma instancia  estatica da classe network   public static NetworkManager instance;
    public static NetworkManager instance;

 private void Awake() // metodo chamado quando o script é inicializado
    {
        if (instance == null)
        { // verifica se a instancia é nula
            instance = this; // define a instancia para este objeto
            DontDestroyOnLoad(gameObject); // Nao destroi o objeto ao carregar uma nova conta
        }
        else if ( instance != this)
        {
            Destroy(gameObject);// destroi o objeto se ja houve uma instancia existente
        }
    }

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();// cONECTAR AO SERVIDOR pHOTON USANDO CONFIGURACOES DEFINIDAS
    }
    public override void OnConnectedToMaster()//loga uma mensagem no console
    {
        Debug.Log("Connected Succrssful");
        MenuManager.instance.Connected();// Chama o metodo conneceted dp menumanager
    }

}
