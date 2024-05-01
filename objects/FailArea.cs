using Godot;
using System;

public partial class FailArea : Area2D
{
	[Signal]
	public delegate void BallEnteredEventHandler();

	public void OnBodyEntered(Node2D body)
	{
		if(body.GetType() == typeof(Ball))
		{
			EmitSignal(SignalName.BallEntered);
		}
	}
}
