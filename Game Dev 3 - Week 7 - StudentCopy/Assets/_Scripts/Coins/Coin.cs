using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class Coin : MonoBehaviour
    {
        //To give each coin a value
        [SerializeField] int coinValue;

        //To get coin value
        public int CoinValue
        {
            get
            {
                return coinValue;
            }
        }
    }
}
