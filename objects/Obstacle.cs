using Godot;
using System;

public partial class Obstacle : Node2D
{
    public override void _Draw()
    {
		  Color white = Colors.White;
		
		  DrawCircle(Vector2.Zero, 9.8723f, white);
    }
}
