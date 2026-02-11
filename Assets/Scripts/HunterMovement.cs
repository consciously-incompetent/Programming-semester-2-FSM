using UnityEngine;

public class HunterMovement : MonoBehaviour
{
    public float speed;
    public Vector3 test;
    public GameObject ground;
    float width;
    float length;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        width = ground.GetComponent<MeshCollider>().bounds.size.x/2;
        Debug.Log(width);
         length = ground.GetComponent<MeshCollider>().bounds.size.z/2;
        Debug.Log(length);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Debug.Log(pos.z);

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



        transform.position = pos;
        //test = pos;
    }
}
