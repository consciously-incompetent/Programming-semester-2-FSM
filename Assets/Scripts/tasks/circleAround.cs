using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class circleAround : ActionTask {
		public BBParameter<List<Vector3>> positions;
		public BBParameter<float> rotateSpeed;
		public BBParameter<int> currentIndex;
		public BBParameter<GameObject> Me;


		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			StartCoroutine(Rotate());
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

		private IEnumerator Rotate()
		{
			float t = 0f;
			Vector3 currentTrans = Me.value.GetComponent<Transform>().position;
			while (t < 1f)
			{
				t += Time.deltaTime * rotateSpeed.value;

				Me.value.GetComponent<Transform>().position = Vector3.Lerp(currentTrans, positions.value[currentIndex.value],t);
				yield return null;
			}
			EndAction(true);
		}
	}
}