using Godot;

public partial class Circle : Node2D
{
    public override void _Draw()
    {
		  Color red = Colors.Red;
		
		  DrawCircle(Vector2.Zero, 9.8723f, red);
    }
}
