using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5;
    public float controlInputX;
    public float controlInputZ;
    public Vector3 mousePos;
    public Vector2 pastMousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 position = transform.position;
       Quaternion rotation = transform.rotation;
       controlInputX = Input.GetAxis("Horizontal");
       controlInputZ = Input.GetAxis("Vertical");
        mousePos = Input.mousePosition;
        float testX = mousePos.x - pastMousePos.x;
        

        //rotation.x += testX * Time.deltaTime;

        position.x += speed * controlInputX * Time.deltaTime;
        position.z += speed * controlInputZ * Time.deltaTime;






        transform.position = position;
        transform.rotation = rotation;
        pastMousePos = mousePos;

    }
}
