using Godot;
using System;

[GlobalClass]
public partial class DialogueLine : Resource
{
    [Export] public DialogueSpeaker Speaker { get; set; }
    [Export(PropertyHint.MultilineText)] public string Text { get; set; }
}
