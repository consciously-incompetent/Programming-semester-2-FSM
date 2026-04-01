using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Actions {

	public class CallEvent : ActionTask {

		public ScoreTracker scoreTracker;

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			scoreTracker.SheepDecrease(-1);
			EndAction(true);
		}

	}
}