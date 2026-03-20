using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {
    

    public class amountOfGameObjects : ConditionTask {
        //public BBParameter<GameObject> closestObject;
        //public BBParameter<int> NmbOfObject; 
        public BBParameter<float> Radius;
		public BBParameter<int> Limit;
        public BBParameter<LayerMask> TargetLayerMask;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
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
            Collider[] Colliders = Physics.OverlapSphere(agent.transform.position, Radius.value, TargetLayerMask.value);
			//NmbOfObject.value = Colliders.Length;
			if(Colliders.Length >= Limit.value){
				return true;
			}
			return false;

		}
	}
}