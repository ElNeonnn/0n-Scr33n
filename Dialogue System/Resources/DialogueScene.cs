using Godot;
using System;

[GlobalClass]
public partial class DialogueScene : Resource
{
    [Export] public DialogueLine[] Lines { get; set; }
}
