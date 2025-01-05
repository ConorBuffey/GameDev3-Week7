using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GlobalData globalData;

        private void Start()
        {
            if (globalData != null)
            {
                //To reset the game
                globalData.ResetsScore();
                globalData.SetTheScoreRequiredToWin();
            }
            else
            {
                Debug.LogWarning("The Global Data SO has not been assigned to the Game Manager");
            }
        }

        public void GameWon()
        {
            //Stops the player
            Time.timeScale = 0;
            //Prints a message to the console
            Debug.Log("Game Won!");
        }
    }
}
