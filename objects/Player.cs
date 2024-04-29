using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	public Vector2 ScreenSize;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    public override void _Ready()
    {
		ScreenSize = GetViewportRect().Size;
    }

    public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

	 	if(Input.IsActionPressed("move_left"))
		{
			velocity.X -= 200;
		}	    

		if(Input.IsActionPressed("move_right"))
		{
			velocity.X += 200;
		}

		Position += velocity * (float)delta;
		Position = new Vector2(
			x: Mathf.Clamp(Position.X, 0, ScreenSize.X),
			y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y)
		);
	}
}
