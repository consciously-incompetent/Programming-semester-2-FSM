using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.Mathematics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveAt : ActionTask {
		public BBParameter<Vector3> moveDir;
		public BBParameter<float> moveSpeed;
		public BBParameter<float> turnSpeed;
	

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			Vector3 normalizedDr = new Vector3(moveDir.value.x, 0, moveDir.value.z).normalized;
			Quaternion desiredRot = Quaternion.LookRotation(normalizedDr);

			agent.transform.rotation = Quaternion.RotateTowards(agent.transform.rotation, desiredRot, turnSpeed.value * Time.deltaTime);

			agent.transform.position += moveSpeed.value * Time.deltaTime * agent.transform.forward;

			moveDir.value = Vector3.zero;



			
		}


	}
}