using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : NPCBaseFSM {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		base.OnStateEnter(animator,stateInfo,layerIndex);
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		Vector3 direction = opponent.transform.position - NPC.transform.position;
		direction.y = 0;
		NPC.transform.rotation = Quaternion.Slerp(NPC.transform.rotation,
									Quaternion.LookRotation(direction), 
									rotSpeed * Time.deltaTime);
	}

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{

	}
}
