using Godot;
using System;

public partial class Ball : RigidBody2D
{
	//[Signal]
	//public delegate void HitEventHandler();

	[Export]
	public Vector2 velocity = new Vector2(250, 250); 

    public override void _Ready()
    {
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
		var collisionInfo = MoveAndCollide(velocity * (float)delta * (float)2.0);

		if (collisionInfo != null)
		{
			velocity = velocity.Bounce(collisionInfo.GetNormal());
		}
    }
}
