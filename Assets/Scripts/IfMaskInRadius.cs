using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class IfMaskInRadius : ConditionTask {
		//setting up variables 
		
		//once the rayCast scan hits a mask it returns the transform that it found 
		public BBParameter<Transform> FoundObject;

		
		[Tooltip("radius at which the mask is scanned")]
		//a pbulci blackboard used for the radius in which the mask is scanned for 
        public BBParameter<float> ScanRadiusBB;

		//mask that is scanned for 
		public LayerMask TargetLayermask;


		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {

			//creates a collider overlapSphere at the agents position and that returns each object within it that has target layer 
            Collider[] colliders = Physics.OverlapSphere(agent.transform.position, ScanRadiusBB.value, TargetLayermask);
			//
            foreach (Collider collider in colliders)
			{
				//gets the transform of the objects in the collider 
                Transform pos = collider.GetComponentInParent<Transform>();

				//assigns the last object to the found object vairable
				//then returns true ending the condition
				FoundObject.value = pos;
                return true;

            }
			return false;
                
		}
	}
}