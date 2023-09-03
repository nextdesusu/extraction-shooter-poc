using Godot;
using System;

public partial class PlayerMove : CharacterBody2D
{
	[Export]
	public ushort Speed {get; set;} = 300;

	public void GetInput()
	{
		LookAt(GetGlobalMousePosition());
		var inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection.Normalized() * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
}
