namespace Nenov.DelegatesExample.WinFormUI
{
  partial class DelegatesExampleForm
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.SubtotalLabel = new System.Windows.Forms.Label();
      this.TotalLabel = new System.Windows.Forms.Label();
      this.SubtotalTextBox = new System.Windows.Forms.TextBox();
      this.TotalTextBox = new System.Windows.Forms.TextBox();
      this.CalcButton = new System.Windows.Forms.Button();
      this.MessageButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // SubtotalLabel
      // 
      this.SubtotalLabel.AutoSize = true;
      this.SubtotalLabel.Location = new System.Drawing.Point(12, 9);
      this.SubtotalLabel.Name = "SubtotalLabel";
      this.SubtotalLabel.Size = new System.Drawing.Size(79, 25);
      this.SubtotalLabel.TabIndex = 0;
      this.SubtotalLabel.Text = "Subtotal";
      // 
      // TotalLabel
      // 
      this.TotalLabel.AutoSize = true;
      this.TotalLabel.Location = new System.Drawing.Point(310, 9);
      this.TotalLabel.Name = "TotalLabel";
      this.TotalLabel.Size = new System.Drawing.Size(49, 25);
      this.TotalLabel.TabIndex = 0;
      this.TotalLabel.Text = "Total";
      // 
      // SubtotalTextBox
      // 
      this.SubtotalTextBox.Location = new System.Drawing.Point(12, 37);
      this.SubtotalTextBox.Name = "SubtotalTextBox";
      this.SubtotalTextBox.Size = new System.Drawing.Size(150, 31);
      this.SubtotalTextBox.TabIndex = 1;
      // 
      // TotalTextBox
      // 
      this.TotalTextBox.Location = new System.Drawing.Point(310, 37);
      this.TotalTextBox.Name = "TotalTextBox";
      this.TotalTextBox.Size = new System.Drawing.Size(150, 31);
      this.TotalTextBox.TabIndex = 1;
      // 
      // CalcButton
      // 
      this.CalcButton.Location = new System.Drawing.Point(12, 106);
      this.CalcButton.Name = "CalcButton";
      this.CalcButton.Size = new System.Drawing.Size(150, 34);
      this.CalcButton.TabIndex = 2;
      this.CalcButton.Text = "Calc";
      this.CalcButton.UseVisualStyleBackColor = true;
      this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
      // 
      // MessageButton
      // 
      this.MessageButton.Location = new System.Drawing.Point(310, 106);
      this.MessageButton.Name = "MessageButton";
      this.MessageButton.Size = new System.Drawing.Size(150, 34);
      this.MessageButton.TabIndex = 2;
      this.MessageButton.Text = "Message";
      this.MessageButton.UseVisualStyleBackColor = true;
      this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
      // 
      // DelegatesExampleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(502, 179);
      this.Controls.Add(this.MessageButton);
      this.Controls.Add(this.CalcButton);
      this.Controls.Add(this.TotalTextBox);
      this.Controls.Add(this.SubtotalTextBox);
      this.Controls.Add(this.TotalLabel);
      this.Controls.Add(this.SubtotalLabel);
      this.Name = "DelegatesExampleForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Delegates example";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label SubtotalLabel;
    private System.Windows.Forms.Label TotalLabel;
    private System.Windows.Forms.TextBox SubtotalTextBox;
    private System.Windows.Forms.TextBox TotalTextBox;
    private System.Windows.Forms.Button CalcButton;
    private System.Windows.Forms.Button MessageButton;
  }
}

