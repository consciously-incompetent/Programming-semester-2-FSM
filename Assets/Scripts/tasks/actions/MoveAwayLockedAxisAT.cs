using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveAwayLockedAxisAT : ActionTask {
		public BBParameter<Transform> target;
		public BBParameter<float> speed;
		public float distanceAmount;
		public bool lockY;
		public bool lockX;
		public bool lockZ;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			Vector3 pos = agent.transform.position;
			Vector3 dir = (target.value.position - pos).normalized ;
            if (lockY)
            {
			dir.y = 0;
			}
			if (lockZ)
			{
				dir.z = 0;
			}
			if (lockX)
			{
				dir.x = 0;
			}


			pos -= dir * speed.value * Time.deltaTime;

			if(Vector3.Distance(target.value.position, pos) > distanceAmount)
            {
				EndAction(true);
            }

			agent.transform.position = pos;




			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}