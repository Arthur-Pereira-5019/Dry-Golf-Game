using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public int par;
    public int tacadas;
    public int pontuacao;

    public int mapa;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void tacada() {
        tacadas++;
        pontuacao = tacadas-par;
    }

    void finalizarPartida () {
        if(PlayerPrefs.GetInt("recorde"+mapa, 0) < pontuacao) {
            PlayerPrefs.SetInt("recorde"+mapa, pontuacao);
        }
    }
}
