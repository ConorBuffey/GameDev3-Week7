using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Managers;
using GameDevWithMarco.CameraStuff;

namespace GameDevWithMarco
{
    public class CollectCoinsOnTriggerEnter : MonoBehaviour
    {
        //<Summary>
        //I made this script to be reusablefrom anything that I want to be able
        //to collect coins, like the player and the axe.
        //</Summary>

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                //Gets the value of the coin and stores it in a variable
                int coinValue = collision.GetComponent<Coin>().CoinValue;
                //To add to the score
                GameManager.Instance.AddToScore(coinValue);
                //Destroys the coin
                Destroy(collision.gameObject);
            }
        }
    }
}
