using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class ATToggleScouting : ActionTask {

		public BBParameter<bool> scouttingBBP;
        public AudioSource audioSource;
		public AudioClip whistleSFX;




        protected override void OnExecute()
        {
            scouttingBBP.value = !scouttingBBP.value;

            Debug.Log("t");

            EndAction(true);
        }

	}
}