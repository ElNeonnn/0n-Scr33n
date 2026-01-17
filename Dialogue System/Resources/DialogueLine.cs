using Godot;
using System;

[GlobalClass]
public partial class DialogueLine : Resource
{
    [Export(PropertyHint.MultilineText)] public string Text { get; set; }
}
