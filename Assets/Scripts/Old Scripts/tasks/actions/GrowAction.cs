using NodeCanvas.Framework;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion.Design;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NodeCanvas.Tasks.Actions {

	public class GrowAction : ActionTask {
		public Vector3 size;
		int GrowthShrink = 1;
		public float MaxSize;
		public float MinSize;
        public GameObject player;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {

			
            return null;

		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			Movement PlayerScript = player.GetComponent<Movement>();
			agent.transform.localScale = Vector3.one * MinSize;
			PlayerScript.clicked = false;

            //EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			size = agent.transform.localScale;
            size += Vector3.one * GrowthShrink * Time.deltaTime;



			if (size.x >= MaxSize)
			{
				GrowthShrink *= -1;
			}
			if (size.x <= MinSize)
			{
                GrowthShrink *= -1;
            }

			agent.transform.localScale = size;




		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}