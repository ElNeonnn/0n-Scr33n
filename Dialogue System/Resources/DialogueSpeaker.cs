using Godot;
using System;

[GlobalClass]
public partial class DialogueSpeaker : Resource
{
	[Export] public SpriteFrames Sprites { get; set; }
	[Export] public string Name { get; set; }
}
