using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Managers;
using GameDevWithMarco.CameraStuff;
using GameDevWithMarco.ObserverPattern;
using GameDevWithMarco.Data;

namespace GameDevWithMarco
{
    public class CollectCoinsOnTriggerEnter : MonoBehaviour
    {
        //<Summary>
        //I made this script to be reusablefrom anything that I want to be able
        //to collect coins, like the player and the axe.
        //</Summary>

        //To notify anyone listening that a coin has been collected
        [SerializeField] GameEvent coinCollected;
        [SerializeField] GlobalData globalData;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                //Gets the value of the coin and stores it in a variable
                int coinValue = collision.GetComponent<Coin>().CoinValue;
                //To add to the score
                if (globalData != null)
                {
                    globalData.AddToScore(coinValue);
                }
                else
                {
                    Debug.LogWarning("Global Data SO not assigned to CollectCoinOnTriggerEnter script");
                }
                //Destroys the coin
                Destroy(collision.gameObject);
                //Raises the event for any listeners to react to
                coinCollected.Raise();
            }
        }
    }
}
