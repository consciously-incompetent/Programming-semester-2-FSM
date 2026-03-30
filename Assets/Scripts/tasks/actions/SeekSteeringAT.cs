using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class SeekSteeringAT : ActionTask {

		public BBParameter<Transform> seekTarget;
		public BBParameter<Vector3> moveDir;
		public float weight;



		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			moveDir.value += (seekTarget.value.position - agent.transform.position).normalized * weight;



		}

		
	}
}