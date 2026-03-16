using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Linq;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class closestObjectInLayer : ActionTask {

		public BBParameter<GameObject> closestObject;
		public BBParameter<float> Radius;
		public BBParameter<LayerMask> TargetLayerMask;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			Collider[] Colliders = Physics.OverlapSphere(agent.transform.position, Radius.value, TargetLayerMask.value);

			if(Colliders.Length > 0) 
			{
				closestObject.value = Colliders[0].gameObject;
			foreach (Collider NearbyCollider in Colliders)
			{
				if(Vector3.Distance(NearbyCollider.transform.position,agent.transform.position) < Vector3.Distance(closestObject.value.transform.position, agent.transform.position)){
					closestObject.value = NearbyCollider.gameObject;
				}
			}

			}
			else
			{
				
				EndAction(false);
			}



				EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}