using NodeCanvas.Tasks.Actions;
using Unity.Mathematics;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float turnSpeed = 240f;
    public AudioClip inRangeClip;



    // Update is called once per frame
    void Update()
    {
        Vector3 direction = SteeringUtility.seek(transform.position, target.position);
        Move(direction);
        if(Vector3.Distance(transform.position, target.position) < 5f)
        {
            audioManager.Instance.playOnShot(inRangeClip);
        }

        
    }


    private void Move(Vector3 direction)
    {
        Vector3 newpos = transform.position + Time.deltaTime * speed * direction;

        quaternion desiredRotation = Quaternion.LookRotation(direction);
        quaternion newRotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, Time.deltaTime * turnSpeed);

        transform.SetPositionAndRotation(newpos, newRotation);
    }
}
