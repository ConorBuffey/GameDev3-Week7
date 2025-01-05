using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;

namespace GameDevWithMarco
{
    public class GameManager : Singleton<GameManager>
    {
        private int score;

        //Getter
        public int Score
        {
            get
            {
                return score;
            }

        }

        //Setter
        public void AddToScore(int numberToAdd)
        {
            score += numberToAdd;
            Debug.Log($"Thecurrent score is {score}");
        }
    }
}
