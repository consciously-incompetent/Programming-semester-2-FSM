using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class randomPointNearMe : ActionTask {

		public BBParameter<Vector3> PointNearMeBB;

		[Description("max and minimum range")]
		public float Range;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			Vector3 PointNearMe = Vector3.zero;
			Vector3 pos = agent.transform.position;
			//pos = pos.normalized;
			PointNearMe.x = pos.x + Random.Range(-Range,Range);
            PointNearMe.z = pos.x + Random.Range(-Range, Range);

			
			PointNearMeBB.value = PointNearMe;
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