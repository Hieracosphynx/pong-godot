using Godot;
using System;

public partial class Main : Node
{

	public void HitEventOccured()
	{
		GetNode<Ball>("Ball").HitEventOccured();
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		InitBall();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void InitBall()
	{
		//Ball ball = GetNode<Ball>("Ball");
		//float direction = Mathf.Pi / 2;

		//direction += (float)GD.RandRange(-Mathf.Pi / 4, Mathf.Pi / 4);
		//ball.Rotation = direction;

		//var velocity = new Vector2((float)GD.RandRange(150.0, 250.0), 0);
		//ball.LinearVelocity = velocity.Rotated(direction);
	}
}
