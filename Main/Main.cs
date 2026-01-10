using Godot;
using System;

public partial class Main : Node
{
	[Export] private PackedScene BalloonScene { get; set; }
	[Export] private DialogueScene Dialogue { get; set; }

	public override void _Ready()
	{
		var balloon = BalloonScene.Instantiate<Balloon>();
		AddChild(balloon);

		balloon.StartDialogue(Dialogue);
	}
}
