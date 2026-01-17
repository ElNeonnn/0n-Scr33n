using Godot;
using System;

[GlobalClass]
public partial class DialogueSpeaker : Resource
{
    [Export] public SpriteFrames Frames { get; set; }
    [Export] public string Name { get; set; }
}
