using Godot;
using System;

public partial class Balloon : Control
{
	private DialogueScene _dialogue;
	private int index;

	public void StartDialogue(DialogueScene dialogue)
	{
		_dialogue = dialogue;
		index = 0;

		Show();
	}
}
