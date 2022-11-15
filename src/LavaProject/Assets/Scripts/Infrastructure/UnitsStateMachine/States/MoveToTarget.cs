using UnityEngine;
using Pathfinding;
using UnitsStateMachine;

public class MoveToTarget : State
{
    public MoveToTarget(IMovable movable, AIDestinationSetter aiDestinationSetter, Animator animator)
    {
        _movable = movable;
        _aiDestinationSetter = aiDestinationSetter;
        _animator = animator;
    }

    private readonly IMovable _movable;

    private readonly AIDestinationSetter _aiDestinationSetter;

    private readonly Animator _animator;

    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    public override void Enter()
    {
        _animator.SetBool(IsWalking, true);
    }

    public override void Tick()
    {
        _movable.MoveToPoint(_aiDestinationSetter);
    }
}