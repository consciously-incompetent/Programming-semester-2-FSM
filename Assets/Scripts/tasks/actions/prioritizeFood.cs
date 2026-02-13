using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class prioritizeFood : ActionTask {
		//setting up variables 

		//creating a public for all of my bushes
		//if you were to add more bushes to the level they would need to be placed in this list 
		public List<GameObject> bushes;
		//this list gets filled out during runtime and is filled with bushes that have berries 
		List<GameObject> bushesWithBerry;

		// this is the specfic bush that the deer will pathfind to 
		public BBParameter<GameObject> Berry;

		//used for deciding which bush to go to 
		int Choice;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {  
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//empty the previous busheswithberry list 
            bushesWithBerry = new List<GameObject>();

			//for each bush in the bushes list I check if that bush has berris and if it does I add it to the second list 
            foreach (var bush in bushes)
            {
                if (bush.GetComponent<Berries>().HasBerries == true)
                {
                    bushesWithBerry.Add(bush);
                    //bush.GetComponent<Berries>().HasBerries = false;
                    
                }
            }
			//as long as that list isn't empty i genereate a random number that corresponds with 1 of bushes with berries, then remove its berries and set it as the destination for the dee
			if (bushesWithBerry != null)
			{
				Choice = Random.Range(0, bushesWithBerry.Count - 1);
				bushesWithBerry[Choice].GetComponent<Berries>().HasBerries = false;
				Berry.value = bushesWithBerry[Choice];
			}

            EndAction(true);


        }


	}
}