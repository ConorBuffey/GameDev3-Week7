using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;
        [SerializeField] GlobalData globalData;

        //Will use this method to update the score text UI
        public void UpdateScoreText()
        {
            if (globalData != null)
            {
                //Uses rich text to make score bold using html-like notation
                scoreText.text = $"<b>Score</b>:{globalData.Score}";
            }
            else
            {
                Debug.Log("No Global Data SO assigned to the UIManager");
            }
        }
    }
}
