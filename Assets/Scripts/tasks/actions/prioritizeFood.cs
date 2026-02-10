using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class prioritizeFood : ActionTask {
		public List<GameObject> bushes;
		List<GameObject> bushesWithBerry;
		public BBParameter<GameObject> Berry;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {  
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            bushesWithBerry = new List<GameObject>();

            foreach (var bush in bushes)
            {
                if (bush.GetComponent<Berries>().HasBerries == true)
                {
                    bushesWithBerry.Add(bush);
                    bush.GetComponent<Berries>().HasBerries = false;
                    
                }
            }
            Berry.value = bushesWithBerry[Random.Range(0,bushesWithBerry.Count-1)];
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