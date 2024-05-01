using Godot;
using System;

public partial class HUD : Node
{
	public void UpdateMessage(String str)
	{
		GetNode<Label>("ScoreLabel").Text = str;
	}
}
