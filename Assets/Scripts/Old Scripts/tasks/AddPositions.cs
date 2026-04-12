using JetBrains.Annotations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AddPositions : ActionTask {
		public BBParameter<List<Vector3>> positions;
		public BBParameter<GameObject> target;
		public BBParameter<float> radious;
		public BBParameter<float> rotateSpeed;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			addPositions();

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


		private void addPositions()
		{
			Transform targetTrans = target.value.GetComponent<Transform>();
			List<Vector3> tempPos = new List<Vector3>();

			for(int i = 0; i < 360; i++)
			{
                float x = targetTrans.position.x + radious.value * Mathf.Cos(i * Mathf.Deg2Rad);
                float z = targetTrans.position.z + radious.value * Mathf.Sin(i * Mathf.Deg2Rad);
				tempPos.Add(new Vector3(x, targetTrans.position.y, z));

            }
			positions.SetValue(tempPos);


        }
		

	}
}