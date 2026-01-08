using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5;
    public float controlInputX;
    public float controlInputZ;
    public Vector3 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 position = transform.position;
       controlInputX = Input.GetAxis("Horizontal");
       controlInputZ = Input.GetAxis("Vertical");

        mousePos = Camera.main.WorldToScreenPoint(position);

        position.x += speed * controlInputX * Time.deltaTime;
        position.z += speed * controlInputZ * Time.deltaTime;






        transform.position = position;
    }
}
