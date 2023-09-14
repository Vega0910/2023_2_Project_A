using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSington<GameManager>
{
    public int playerScore = 0;

    public void InscreaseScore(int amount)
    {
        playerScore += amount;
    }
}
