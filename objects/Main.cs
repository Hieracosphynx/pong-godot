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

	public void IncrementScore()
	{
		Score++;
		GetNode<HUD>("HUD").UpdateMessage(Score.ToString());
	}

	async public void GameOver()
	{
		GetNode<HUD>("HUD").UpdateMessage("Game Over!");

		await ToSignal(GetTree().CreateTimer(2.0), SceneTreeTimer.SignalName.Timeout);

		GetTree().ReloadCurrentScene();
	}
}
