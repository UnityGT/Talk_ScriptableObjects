using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerReader : MonoBehaviour {

    public Text winnerText;
    public GameData gameData;

	// Use this for initialization
	void Start () {
        winnerText.text = gameData.winnerProfile.name;
        winnerText.color = gameData.winnerProfile.mainColor;
    }

}
