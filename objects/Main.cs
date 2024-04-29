using Godot;
using System;

public partial class Main : Node
{
	public int Score = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<HUD>("HUD").UpdateMessage(Score.ToString());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void IncrementScore()
	{
		Score++;
		GetNode<HUD>("HUD").UpdateMessage(Score.ToString());
	}

	async public void GameOver()
	{
		GetNode<HUD>("HUD").UpdateMessage("Game Over!");

		await ToSignal(GetTree().CreateTimer(5.0), SceneTreeTimer.SignalName.Timeout);

		Score = 0;
	}
}
