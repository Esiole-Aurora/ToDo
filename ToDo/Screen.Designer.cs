namespace ToDo;

partial class Screen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        NewNoteButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // NewNoteButton
        // 
        NewNoteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        NewNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
        NewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        NewNoteButton.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        NewNoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
        NewNoteButton.Location = new System.Drawing.Point(720, 380);
        NewNoteButton.Margin = new System.Windows.Forms.Padding(5);
        NewNoteButton.Name = "NewNoteButton";
        NewNoteButton.Size = new System.Drawing.Size(65, 65);
        NewNoteButton.TabIndex = 0;
        NewNoteButton.Text = "+";
        NewNoteButton.UseVisualStyleBackColor = false;
        NewNoteButton.Click += NewNoteButton_Click;
        // 
        // Screen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.DarkSlateGray;
        ClientSize = new System.Drawing.Size(802, 453);
        Controls.Add(NewNoteButton);
        Text = "ToDo";
        Resize += Screen_Resize;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button NewNoteButton;

    #endregion
}