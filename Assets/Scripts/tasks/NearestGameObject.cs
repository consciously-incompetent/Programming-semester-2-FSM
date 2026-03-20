using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {
    

    public class NearestGameObject : ConditionTask {
        public BBParameter<GameObject> closestObject;
        public BBParameter<float> Radius;
        public BBParameter<LayerMask> TargetLayerMask;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            Collider[] Colliders = Physics.OverlapSphere(agent.transform.position, Radius.value, TargetLayerMask.value);

            if (Colliders.Length > 0)
            {
                closestObject.value = Colliders[0].gameObject;
                foreach (Collider NearbyCollider in Colliders)
                {
                    if (Vector3.Distance(NearbyCollider.transform.position, agent.transform.position) < Vector3.Distance(closestObject.value.transform.position, agent.transform.position))
                    {
                        closestObject.value = NearbyCollider.gameObject;
                    }
                }

            }
            else
            {

                return false;
            }

            return true;
		}
	}
}