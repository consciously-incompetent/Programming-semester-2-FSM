using UnityEngine;

public class MoveMentBetter : MonoBehaviour
{
    public float speed;
    public float accRate;
    public float AccMax;


    public float acc;
    Vector3 pastmov = new Vector3(0, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float XDir = Input.GetAxis("Vertical");
        float ZDir= Input.GetAxis("Horizontal");
        Vector3 mov = new Vector3(XDir, 0, -ZDir).normalized;
        

        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {

            if (acc < AccMax)
            {
                acc += accRate * Time.deltaTime;
            }
            else
            {
                acc = AccMax;
            }
            pastmov = mov;
        } else
        {
            if(acc > 0)
            {
                acc -= accRate * Time.deltaTime;
                mov = pastmov;
            }
            else
            {
                acc = 0;
                pastmov = Vector3.zero;
            }
        }



            transform.position -= Time.deltaTime * mov * (speed + acc); 







    }
}
