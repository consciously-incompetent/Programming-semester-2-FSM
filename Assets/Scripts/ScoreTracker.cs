using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public int sheepCount;
    public GameObject sheep;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        summonSheep(5);
    }

    // Update is called once per frame
    void Update()
    {
        if(sheepCount >= 0)
        {
            summonSheep(5);
        }



    }

    public void ScoreChange(int amount)
    {
        score += amount;
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
