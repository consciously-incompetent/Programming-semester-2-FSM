using UnityEngine;

public class SetRandomPosiition : MonoBehaviour
{
    public Vector3 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos = transform.position;
        pos.x = Random.Range(-25, 25);
        pos.y = Random.Range(-25, 25);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
