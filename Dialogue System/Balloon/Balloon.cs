using Godot;
using System;

public partial class Balloon : Control
{
	[Export] private Label SpeakerLabel { get; set; }
	[Export] private RichTextLabel LineLabel { get; set; }

	private DialogueScene _dialogue;
	private int index;

	private DialogueSpeaker speaker;
	private DialogueLine line;

    public override void _Ready()
    {
		speaker = _dialogue.Lines[index].Speaker;
		line = _dialogue.Lines[index];
    }

	public void StartDialogue(DialogueScene dialogue)
	{
		_dialogue = dialogue;
		index = 0;

		Show();
	}
}
