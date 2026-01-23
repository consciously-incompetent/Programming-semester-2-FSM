using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class IfMaskInRadius : ConditionTask {

		public BBParameter<Transform> FoundObject;
        public BBParameter<float> ScanRadiusBB;

		public LayerMask TargetLayermask;

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

            Collider[] colliders = Physics.OverlapSphere(agent.transform.position, ScanRadiusBB.value, TargetLayermask);
            foreach (Collider collider in colliders)
			{
                Transform pos = collider.GetComponentInParent<Transform>();

				FoundObject.value = pos;
                return true;

            }
			return false;
                
		}
	}
}