using Microsoft.VisualBasic.Devices;

namespace ToDo;

public partial class Card : UserControl
{
    
    public int Index = 0;
    public Card(int index)
    {
        InitializeComponent();
        Index = index;
    }


    private void CLEAR_Click(object sender, EventArgs e)
    {
        Screen.Cards.RemoveAt(Index);
        this.Controls.Clear();
        this.Dispose();
    }

    private Point _mouseDownLocation;
    
    private void MoveButton_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            _mouseDownLocation = e.Location;
        }
    }
    private void MoveButton_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        this.Left = e.X + this.Left - _mouseDownLocation.X;
        this.Top = e.Y + this.Top - _mouseDownLocation.Y;
    }
}