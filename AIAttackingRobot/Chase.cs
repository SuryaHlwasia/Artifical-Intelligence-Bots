using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : NPCBaseFSM {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		base.OnStateEnter(animator,stateInfo,layerIndex);
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		//rotate towards target
		Vector3 direction = opponent.transform.position - NPC.transform.position;
		direction.y = 0;
		NPC.transform.rotation = Quaternion.Slerp(NPC.transform.rotation,
									Quaternion.LookRotation(direction), 
									rotSpeed * Time.deltaTime);
		NPC.transform.Translate(0, 0, Time.deltaTime * speed);
	}

		override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

}
