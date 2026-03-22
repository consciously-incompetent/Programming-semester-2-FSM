using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.Rendering.DebugUI;


namespace NodeCanvas.Tasks.Actions {

	public class ChangeLayer : ActionTask {
		public BBParameter<LayerMask> changeTo;
		public bool useSelf;
		[Description("don't fill out if useSelf is ticked")]
		public BBParameter<GameObject> TargetGameobject;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
            //changeTo = (1 << layer);
            int layer = changeTo.value;
            Debug.Log(layer);
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
             
            if (useSelf)
			{

				Debug.Log(agent.gameObject.layer);
				
                agent.gameObject.layer = changeTo.value;
                Debug.Log(agent.gameObject.layer);
            }
			else
			{
				TargetGameobject.value.layer = changeTo.value;
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