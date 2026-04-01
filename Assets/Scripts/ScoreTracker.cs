using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public int sheepCount;
    public GameObject sheep;
    public GameObject scoreText;
    //TextMeshPro sText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sText  = scoreText.GetComponent<TextMeshPro>();
        summonSheep(5);
    }

    // Update is called once per frame
    void Update()
    {
        if(sheepCount <= 0)
        {
            summonSheep(5);
        }
    }

    public void ScoreChange(int amount)
    {
        score += amount;
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    public void SheepDecrease(int amount)
    {
        sheepCount += amount;
    }



    private void summonSheep(int amount)
    {
        sheepCount += amount;
        for (int i = 0; i < sheepCount; i++)
        {
            Instantiate(sheep);
        }
    }
}
