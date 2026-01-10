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
		if (ContainsErrors())
		{
			Hide();
			return;
		};

        speaker = _dialogue.Lines[index].Speaker;
        line = _dialogue.Lines[index];

		SpeakerLabel.Text = speaker.Name;
		LineLabel.Text = line.Text;
	}

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("ui_accept") && !ContainsErrors())
		{
			index++;
			WriteLine();
		}
    }

    private bool ContainsErrors()
    {
		if (_dialogue == null)
		{
			return true;
		}

		if (index >= _dialogue.Lines.Length)
		{
			return true;
		}

		return false;
    }
}
