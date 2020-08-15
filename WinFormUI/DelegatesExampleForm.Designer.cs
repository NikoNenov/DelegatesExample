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
      this.subtotalLabel = new System.Windows.Forms.Label();
      this.totalLabel = new System.Windows.Forms.Label();
      this.subtotalTextBox = new System.Windows.Forms.TextBox();
      this.totalTextBox = new System.Windows.Forms.TextBox();
      this.calcButton = new System.Windows.Forms.Button();
      this.messageButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // subtotalLabel
      // 
      this.subtotalLabel.AutoSize = true;
      this.subtotalLabel.Location = new System.Drawing.Point(12, 9);
      this.subtotalLabel.Name = "subtotalLabel";
      this.subtotalLabel.Size = new System.Drawing.Size(79, 25);
      this.subtotalLabel.TabIndex = 0;
      this.subtotalLabel.Text = "Subtotal";
      // 
      // totalLabel
      // 
      this.totalLabel.AutoSize = true;
      this.totalLabel.Location = new System.Drawing.Point(310, 9);
      this.totalLabel.Name = "totalLabel";
      this.totalLabel.Size = new System.Drawing.Size(49, 25);
      this.totalLabel.TabIndex = 0;
      this.totalLabel.Text = "Total";
      // 
      // subtotalTextBox
      // 
      this.subtotalTextBox.Location = new System.Drawing.Point(12, 37);
      this.subtotalTextBox.Name = "subtotalTextBox";
      this.subtotalTextBox.Size = new System.Drawing.Size(150, 31);
      this.subtotalTextBox.TabIndex = 1;
      // 
      // totalTextBox
      // 
      this.totalTextBox.Location = new System.Drawing.Point(310, 37);
      this.totalTextBox.Name = "totalTextBox";
      this.totalTextBox.Size = new System.Drawing.Size(150, 31);
      this.totalTextBox.TabIndex = 1;
      // 
      // calcButton
      // 
      this.calcButton.Location = new System.Drawing.Point(12, 106);
      this.calcButton.Name = "calcButton";
      this.calcButton.Size = new System.Drawing.Size(150, 34);
      this.calcButton.TabIndex = 2;
      this.calcButton.Text = "Calc";
      this.calcButton.UseVisualStyleBackColor = true;
      this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
      // 
      // messageButton
      // 
      this.messageButton.Location = new System.Drawing.Point(310, 106);
      this.messageButton.Name = "messageButton";
      this.messageButton.Size = new System.Drawing.Size(150, 34);
      this.messageButton.TabIndex = 2;
      this.messageButton.Text = "Message";
      this.messageButton.UseVisualStyleBackColor = true;
      this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
      // 
      // DelegatesExampleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(502, 179);
      this.Controls.Add(this.messageButton);
      this.Controls.Add(this.calcButton);
      this.Controls.Add(this.totalTextBox);
      this.Controls.Add(this.subtotalTextBox);
      this.Controls.Add(this.totalLabel);
      this.Controls.Add(this.subtotalLabel);
      this.Name = "DelegatesExampleForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Delegates example";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label subtotalLabel;
    private System.Windows.Forms.Label totalLabel;
    private System.Windows.Forms.TextBox subtotalTextBox;
    private System.Windows.Forms.TextBox totalTextBox;
    private System.Windows.Forms.Button calcButton;
    private System.Windows.Forms.Button messageButton;
  }
}

