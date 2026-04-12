using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace NodeCanvas.Tasks.Actions {

	public class ManageSpriteReactionAT : ActionTask {
		//setting variables 

		// public refrences to the react image and the sprite it ill be set too 
		public Image ReactImage;
		public Sprite Reaction;
		[Tooltip("if true removes sprites")]
		//bool for if this sets or removes reactions
		public bool Remove;
		//colors of transparent and opaque(full color)
		Color transparent;
		Color opaque;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			//setting the transparent and opaque colours to their correct values 
			transparent.a = 0;
			transparent.r = 255;
            transparent.g = 255;
            transparent.b = 255;

            opaque.a = 1;
			opaque.r = 255;
            opaque.g = 255;
            opaque.b = 255;

            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//checks if remove is true if not sets the sprite to the given reaction sets its colour to opaque 
			if (!Remove) {
                ReactImage.GetComponent<Image>().sprite = Reaction;
                ReactImage.GetComponent<Image>().color = opaque;
            } else if (Remove)
			{
				//if the remove is true it instead sets the sprite to null and colour to transparent
				//Debug.Log("test");
				ReactImage.GetComponent<Image>().sprite = null;
				//the reason I do both is because if you just set an image to null it apears asa white square but I also ididn't want to leave invisible images so 
				//the code removes both
				ReactImage.GetComponent<Image>().color = transparent;
			}
				
				EndAction(true);
		}


	}
}