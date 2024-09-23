namespace WinFormsMultiLogProcApp1
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnStart = new System.Windows.Forms.Button();
         this.textBoxCommand = new System.Windows.Forms.TextBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBoxArgs = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.btnStart);
         this.panel1.Controls.Add(this.textBoxArgs);
         this.panel1.Controls.Add(this.textBoxCommand);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1008, 120);
         this.panel1.TabIndex = 0;
         // 
         // btnStart
         // 
         this.btnStart.Location = new System.Drawing.Point(101, 79);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(75, 29);
         this.btnStart.TabIndex = 2;
         this.btnStart.Text = "Start";
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
         // 
         // textBoxCommand
         // 
         this.textBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxCommand.Location = new System.Drawing.Point(101, 9);
         this.textBoxCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.textBoxCommand.Name = "textBoxCommand";
         this.textBoxCommand.Size = new System.Drawing.Size(894, 26);
         this.textBoxCommand.TabIndex = 0;
         this.textBoxCommand.Text = "cmd";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.richTextBox1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(0, 120);
         this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1008, 609);
         this.panel2.TabIndex = 1;
         // 
         // richTextBox1
         // 
         this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.richTextBox1.Location = new System.Drawing.Point(0, 0);
         this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(1008, 609);
         this.richTextBox1.TabIndex = 0;
         this.richTextBox1.Text = "";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(82, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Command";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 45);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(42, 20);
         this.label2.TabIndex = 2;
         this.label2.Text = "Args";
         // 
         // textBoxArgs
         // 
         this.textBoxArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxArgs.Location = new System.Drawing.Point(101, 45);
         this.textBoxArgs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.textBoxArgs.Name = "textBoxArgs";
         this.textBoxArgs.Size = new System.Drawing.Size(894, 26);
         this.textBoxArgs.TabIndex = 1;
         this.textBoxArgs.Text = "/c dir c:\\windows";
         // 
         // Form1
         // 
         this.AcceptButton = this.btnStart;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 729);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MinimumSize = new System.Drawing.Size(640, 480);
         this.Name = "Form1";
         this.Text = "Form1";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.TextBox textBoxCommand;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBoxArgs;
   }
}

