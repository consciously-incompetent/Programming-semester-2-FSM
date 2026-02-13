using UnityEngine;

public class Berries : MonoBehaviour
{
    //setting up variables 

    //bool for if the bush has berries 
    public bool HasBerries = false;
    //time variable to resetinng the berry 
    float t;
    //the time the berry resets 
    public float regrowthTime;


    // Update is called once per frame
    void Update()
    {

        if (HasBerries == false)
        {
            t += Time.deltaTime;
            if(t > regrowthTime)
            {
                HasBerries = true;
                t = 0f;
            }
        }

        
    }
}
