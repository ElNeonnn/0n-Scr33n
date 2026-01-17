using Godot;
using System;

[GlobalClass]
public partial class DialogueOption : Resource
{
    [Export] public string Name { get; set; }
    [Export] public DialogueScene Dialogue { get; set; }
}
