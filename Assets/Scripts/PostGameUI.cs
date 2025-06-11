using UnityEngine;
using TMPro;

public class PostGameUI : MonoBehaviour
{
    [SerializeField] GameObject postGamePanel;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text timeText;

    public void ShowPostGame()
    {
        postGamePanel.SetActive(true);

        coinText.text = "COFRINHO FINAL: " + UIInfo.coinCount;

        float time = PlayerMovement.timePlayed;
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        timeText.text = $"TEMPO JOGADO: {minutes:00}:{seconds:00}";
    }
}
