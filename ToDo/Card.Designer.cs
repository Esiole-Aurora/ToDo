using System.ComponentModel;

namespace ToDo;

partial class Card
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CLEAR = new System.Windows.Forms.Button();
        CardText = new System.Windows.Forms.RichTextBox();
        MoveButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CLEAR
        // 
        CLEAR.BackColor = System.Drawing.Color.LemonChiffon;
        CLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
        CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        CLEAR.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CLEAR.Location = new System.Drawing.Point(71, 107);
        CLEAR.Name = "CLEAR";
        CLEAR.Size = new System.Drawing.Size(119, 43);
        CLEAR.TabIndex = 0;
        CLEAR.Text = "CLEAR";
        CLEAR.UseVisualStyleBackColor = false;
        CLEAR.Click += CLEAR_Click;
        // 
        // CardText
        // 
        CardText.BackColor = System.Drawing.Color.LemonChiffon;
        CardText.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CardText.Location = new System.Drawing.Point(0, 0);
        CardText.Name = "CardText";
        CardText.Size = new System.Drawing.Size(190, 106);
        CardText.TabIndex = 1;
        CardText.Text = "";
        // 
        // MoveButton
        // 
        MoveButton.BackColor = System.Drawing.Color.LemonChiffon;
        MoveButton.Cursor = System.Windows.Forms.Cursors.SizeAll;
        MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        MoveButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MoveButton.Location = new System.Drawing.Point(0, 107);
        MoveButton.Name = "MoveButton";
        MoveButton.Size = new System.Drawing.Size(71, 43);
        MoveButton.TabIndex = 2;
        MoveButton.Text = "MOVE";
        MoveButton.UseVisualStyleBackColor = false;
        MoveButton.MouseDown += MoveButton_MouseDown;
        MoveButton.MouseMove += MoveButton_MouseMove;
        // 
        // Card
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(MoveButton);
        Controls.Add(CardText);
        Controls.Add(CLEAR);
        Size = new System.Drawing.Size(192, 150);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button MoveButton;

    private System.Windows.Forms.Button CLEAR;
    public System.Windows.Forms.RichTextBox CardText;

    #endregion
}