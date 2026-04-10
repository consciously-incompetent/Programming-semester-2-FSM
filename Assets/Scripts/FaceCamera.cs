using NodeCanvas.StateMachines;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class FaceCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Camera target;
    RectTransform Me;

    
    void Start()
    {
        target = FindAnyObjectByType<Camera>();
        Me = this.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 Dir =  (target.transform.position - Me.position).normalized;
        Me.rotation = target.transform.rotation;
        //Quaternion.
        //Vector3.RotateTowards(Me.position, target.transform.position, (45 * Mathf.Deg2Rad),1);



        
    }
}
