using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	
	public class ifBig : ConditionTask {

		//public Movement script;
		public GameObject player;
		//public GrowAction growthScript;
		//public GameObject Cube;
		

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
            Movement script = player.GetComponent<Movement>();
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

			
			Movement script = player.GetComponent<Movement>();
			
			return agent.transform.localScale.x >= 5 * 0.75 && script.clicked;





        }
	}
}