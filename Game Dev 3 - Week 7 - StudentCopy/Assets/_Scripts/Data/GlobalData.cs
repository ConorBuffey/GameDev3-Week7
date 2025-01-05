using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.CameraStuff;
using GameDevWithMarco.ObserverPattern;

namespace GameDevWithMarco.Data
{
    [CreateAssetMenu(fileName = "New Global Data", menuName = "Scriptable Objects/Data")]
    public class GlobalData : ScriptableObject
    {
        private int score = 0;
        private int scoreRequiredToWin;
        [SerializeField] GameEvent gameWon;

        //Encapsulating the score variable so it cant be directly changed
        public int Score
        {
            get
            {
                return score;
            }
        }

        public void ResetsScore()
        {
            //To reset score each time we start playing
            //Without this code will persist between runs
            score = 0;
        }

        public void SetTheScoreRequiredToWin()
        {
            //To reset to starting point
            scoreRequiredToWin = 0;
            //Stores all the coins into an array
            Coin[] storeAllCoins = FindObjectsOfType<Coin>();
            //Goes through the array and adds the coin value to
            //the score required to win variable
            foreach (Coin coin in storeAllCoins)
            {
                scoreRequiredToWin += coin.CoinValue;
            }
        }

        //To add to the score
        public void AddToScore(int amountToAdd)
        {
            //To change any amount to positive so we stop negative values being added
            int sortedScore = Mathf.Abs(amountToAdd);
            //Then we add to the score
            score += sortedScore;

            //To check if we won
            if (score >= scoreRequiredToWin)
            {
                gameWon.Raise();
            }
        }
    }
}

