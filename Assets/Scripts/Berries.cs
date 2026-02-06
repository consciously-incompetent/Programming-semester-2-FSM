using UnityEngine;

public class Berries : MonoBehaviour
{
    public bool HasBerries = false;
    float t;
    public float regrowthTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

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
