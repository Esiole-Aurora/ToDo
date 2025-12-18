using System.Collections;

namespace ToDo;

public partial class Screen : Form
{
    private ArrayList _cards = new ArrayList();
    public Screen()
    {
        InitializeComponent();
    }

    private void Screen_Resize(object sender, EventArgs e)
    {
        NewNoteButton.Location = new Point(this.Width - 100, this.Height - 120);
    }

    private void NewNoteButton_Click(object sender, EventArgs e)
    {
        var rng = new Random();
        var newNote = new Card();
        newNote.Location = new Point(rng.Next(0, this.Width-200), rng.Next(0, this.Height-200));
        _cards.Add(newNote);
        this.Controls.Add(newNote);
    }
}
