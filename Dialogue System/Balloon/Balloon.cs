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

	public void StartDialogue(DialogueScene dialogue)
	{
		_dialogue = dialogue;
		index = 0;

		WriteLine();
		Show();
	}

	private void WriteLine()
	{
        speaker = _dialogue.Lines[index].Speaker;
        line = _dialogue.Lines[index];

		SpeakerLabel.Text = speaker.Name;
		LineLabel.Text = line.Text;
	}

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("ui_accept"))
		{
			index++;
			WriteLine();
		}
    }
}
