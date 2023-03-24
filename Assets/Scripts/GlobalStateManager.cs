using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalStateManager : MonoBehaviour
{
    public List<GameObject> Players = new List<GameObject>();

    private int deadPlayerNum = -1;
    public string mensagem;

    public void PlayerDied(int playerNumber)
    {
        deadPlayerNum = playerNumber;
        Invoke("CheckPlayersDeath", .3f);
        mensagem = CheckPlayersDeath();
    }

    string CheckPlayersDeath()
    {
        if (deadPlayerNum == 1)
        {
            Debug.Log("Player 2 is the winner!");
            return mensagem = "Player 2 Venceu!";
        }
        else
        {
            Debug.Log("Player 1 is the winner!");
            return mensagem = "Player 1 Venceu!";
        }
    }
}
