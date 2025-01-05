using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;

        //Will use this method to update the score text UI
        public void UpdateScoreText()
        {
            //Uses rich text to make Score bold sing html-like notation
            scoreText.text = $"<b>Score</b>:{GameManager.Instance.Score}";
        }
    }
}
