using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public Vector2 ScreenSize;

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
