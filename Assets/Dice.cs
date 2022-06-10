using UnityEngine;
using UnityEngine.UI;
public class Dice : MonoBehaviour
{
    public Text score;
    public Text HightScore;

    private void Start()
    {
        HightScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }
    public void RollDice()
    {
        int numb = Random.Range(1, 7);
        score.text = numb.ToString();
        if(numb > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore", numb);
            HightScore.text = numb.ToString();
        }
    }

    public void Reset()
    {
        //PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.DeleteKey("HighScore");
        HightScore.text = "0";

    }
}
