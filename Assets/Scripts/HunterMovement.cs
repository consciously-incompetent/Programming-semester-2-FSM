using NUnit.Framework.Internal.Commands;
using UnityEngine;

public class HunterMovement : MonoBehaviour
{
    //setting up variables 

    //public speed variable for how the fast the character moves 
    public float speed;
    
    //game object variable which acts as the bound the player character can walk on 
    public GameObject ground;
    //width and height variables which will be filled in with widht and height of the ground gaem object 
    float width;
    float length;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set the width variable to the x of the game object divided by 2 
        width = ground.GetComponent<MeshCollider>().bounds.size.x/2;
        // Debug.Log(width);

        //set the length variable to the z of the game object divided by 2
         length = ground.GetComponent<MeshCollider>().bounds.size.z/2;
        //Debug.Log(length);


        // I divide the results by 2 because that more closely matches the visibile edge of the game object
    }

    // Update is called once per frame
    void Update()
    {
        //create position variables 
        Vector3 pos = transform.position;
        //Debug.Log(pos.z);


        //movement controls that change the pos variable over time multiplied by the speed, only if it is within the bounds of the game object
        if (Input.GetKey(KeyCode.D) && pos.x < width)
        {
            pos += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A) && pos.x > -width)
        {
            pos += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S) && pos.z < length)
        {
            pos += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W) && pos.z > -length)
        {
            pos += Vector3.back * Time.deltaTime * speed;
        }


        //apply the changes to the position 
        transform.position = pos;
        //test = pos;
    }
}
