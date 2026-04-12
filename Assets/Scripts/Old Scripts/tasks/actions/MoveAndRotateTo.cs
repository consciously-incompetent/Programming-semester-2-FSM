using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveAndRotateTo : ActionTask {

		public float stoppingDistance = 0.1f;

		private float speed;
        private float rotateSpeed;
		bool reachTarget = false;
        public Transform target;

		private Blackboard agentBlackboard;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			agentBlackboard = agent.GetComponent<Blackboard>();
			
			if (agentBlackboard != null) return null;
			else return "unable to find blackboard";
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			//target = agentBlackboard.GetVariableValue<Transform>("target");
			speed = agentBlackboard.GetVariableValue<float>("speed");
            rotateSpeed = agentBlackboard.GetVariableValue<float>("rotateSpeed");
            //EndAction(true);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			Vector3 direction = target.position - agent.transform.position;
			Quaternion lookRotation = Quaternion.LookRotation(direction);
			agent.transform.rotation = Quaternion.RotateTowards(agent.transform.rotation, lookRotation, rotateSpeed * Time.deltaTime);
			agent.transform.position += speed * Time.deltaTime * agent.transform.forward;
			

			if(Vector3.Distance(agent.transform.position,target.position) <= stoppingDistance)
			{
                //agentBlackboard.SetVariableValue<bool>("ReachTarget");
                EndAction(true);
			}
		}

		
	
	}
}