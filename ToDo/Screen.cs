using System.Collections;

namespace ToDo;

public partial class Screen : Form
{
    public static readonly ArrayList Cards = new ArrayList();
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
        var newNote = new Card(Cards.Count);
        newNote.Location = new Point(rng.Next(0, this.Width-200), rng.Next(0, this.Height-200));
        Cards.Add(newNote);
        this.Controls.Add(newNote);
    }

    private void Screen_Close(object sender, EventArgs e)
    {
        var fs = new FileStream("cards.csv", FileMode.Create);
        var sw = new StreamWriter(fs);
        foreach (Card card in Cards)
        {
            sw.WriteLine(card.CardText.Text);
        }
        sw.Close();
        fs.Close();
    }

    private void Screen_Load(object sender, EventArgs e)
    {
        var fs = new FileStream("cards.csv", FileMode.Open);
        var sr = new StreamReader(fs);
        var newCards = sr.ReadToEnd().Split("\n");
        foreach (var text in newCards)
        {
            if (text != "")
            {
                var rng = new Random();
                var newNote = new Card(Cards.Count);
                newNote.Location = new Point(rng.Next(0, this.Width - 200), rng.Next(0, this.Height - 200));
                newNote.Text = text;
                Cards.Add(newNote);
                this.Controls.Add(newNote);
            }
        }
        sr.Close();
        fs.Close();
    }
}
