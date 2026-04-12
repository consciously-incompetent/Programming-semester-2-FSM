using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.XR;

namespace NodeCanvas.Tasks.Actions {

	public class GetGameObject : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		
		[Description("GameObject name needs the name of the name of the object that is being found")]
		public string GameObjectName;
		public BBParameter<GameObject> SetGameObject;
		
        protected override string OnInit() {
            
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			if(GameObject.Find(GameObjectName) != null)
			{
                SetGameObject.value = GameObject.Find(GameObjectName);
            }
			else
			{
				Debug.Log("couldn't find named object");
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