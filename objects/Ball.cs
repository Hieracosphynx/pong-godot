using Godot;
using System;

public partial class Ball : RigidBody2D
{
	[Signal]
	public delegate void BallHitEventHandler();

	[Export]
	public Vector2 velocity = new Vector2(250, 250); 

    public override void _PhysicsProcess(double delta)
    {
		var collisionInfo = MoveAndCollide(velocity * (float)delta * (float)2.0);

		if (collisionInfo != null)
		{
			var collider = collisionInfo.GetCollider();

			velocity = velocity.Bounce(collisionInfo.GetNormal());

			if(collider.GetType() == typeof(Player))
			{
				EmitSignal(SignalName.BallHit);
			}
		}
    }
}
