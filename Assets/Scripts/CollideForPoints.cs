using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class CollideForPoints : MonoBehaviour
{
    //public Collider InPen;
    public ScoreTracker tracker;
    public int decreaseIncrease;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("test");
        Debug.Log(other);

        tracker.ScoreChange(decreaseIncrease);
        tracker.SheepDecrease(-1);

        other.gameObject.SetActive(false);
        Destroy(other.gameObject);

    }

   

}
