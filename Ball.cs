using Godot;
using System;

public partial class Ball : RigidBody2D
{
	[Signal]
	public delegate void HitEventHandler();

	[Export]
	public int Speed = 150;
	[Export]
	public Vector2 velocity = new Vector2(150, 150); 

	public Vector2 ScreenSize;
	private bool IsHit;

    public override void _Ready()
    {
		ScreenSize = GetViewportRect().Size;
		IsHit = false;
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//var velocity = Vector2.Zero;

		//if(IsHit)
		//{
			//velocity.Y -= 150; 
			//IsHit = false;

			//LinearVelocity += velocity * (float)delta;
			//LinearVelocity = new Vector2(
				//x: Mathf.Clamp(Position.X, 0, ScreenSize.X),
				//y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y));
		//}

	}

    public override void _PhysicsProcess(double delta)
    {
		var collisionInfo = MoveAndCollide(velocity * (float)delta);

		if (collisionInfo != null)
		{
			velocity = velocity.Bounce(collisionInfo.GetNormal());
			GD.Print(collisionInfo.GetNormal());
		}
    }

    public void OnBodyEntered(Node body)
	{
		EmitSignal(SignalName.Hit);
	}

	public void HitEventOccured()
	{
		IsHit = true;
		GD.Print("I am confused..");
	}
}
