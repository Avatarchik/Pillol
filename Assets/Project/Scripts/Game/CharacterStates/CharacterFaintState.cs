using UnityEngine;
using System.Collections;
using FiniteStateMachine;

public class CharacterFaintState<T> : CharacterBaseState
{
    public override void Start()
    {
        Debug.Log("DIED :(");
		Fsm.Entity.SetAnimation ("Dead", 1f);
		Fsm.Entity.GetComponent<BoxCollider> ().enabled = false;
    }
    
    public override void Update()
    {
    }
    
    public override void End()
    {
    }

    public new void triggerHit(BulletBehaviour bullet)
    {

    }
}
