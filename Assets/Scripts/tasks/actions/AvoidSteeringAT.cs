using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AvoidSteeringAT : ActionTask {

		public BBParameter<Vector3> moveDir;
		public LayerMask avoidLayers;
		public float closeRad, nearRad, farRad;
		public float closeWeight, nearWeight, farWeight;


		//Called once per frame while the action is active.
		protected override void OnUpdate() 
		{

			moveDir.value += calcAvoidVector();

		}

		private Vector3 calcAvoidVector()
		{
			Collider[] detectedColliders = Physics.OverlapSphere(agent.transform.position, farRad, avoidLayers);
			Vector3 avoidDir = Vector3.zero;
			foreach(Collider collider in detectedColliders)
			{
				float weight = 0f;
				float DisToCollider = Vector3.Distance(agent.transform.position, collider.transform.position);

					if(DisToCollider < closeRad)
				{
					weight = closeWeight;
				} else if (DisToCollider < nearRad)
				{
					weight = nearWeight;
				}
				else
				{
					weight = farWeight;
				}
				Vector3 direction = (agent.transform.position - collider.transform.position).normalized;
				avoidDir += direction * weight;



			}

			return avoidDir;
				
		}

	}
}