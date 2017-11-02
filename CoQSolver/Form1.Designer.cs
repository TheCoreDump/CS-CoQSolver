namespace CoQSolver
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
			this.APanel = new System.Windows.Forms.Panel();
			this.TopSplitter = new System.Windows.Forms.Splitter();
			this.BPanel = new System.Windows.Forms.Panel();
			this.BAPanel = new System.Windows.Forms.Panel();
			this.BBPanel = new System.Windows.Forms.Panel();
			this.SourceTextBox = new System.Windows.Forms.TextBox();
			this.TargetTextBox = new System.Windows.Forms.TextBox();
			this.ProcessButton = new System.Windows.Forms.Button();
			this.APanel.SuspendLayout();
			this.BPanel.SuspendLayout();
			this.BAPanel.SuspendLayout();
			this.BBPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// APanel
			// 
			this.APanel.Controls.Add(this.SourceTextBox);
			this.APanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.APanel.Location = new System.Drawing.Point(0, 0);
			this.APanel.Name = "APanel";
			this.APanel.Size = new System.Drawing.Size(487, 159);
			this.APanel.TabIndex = 0;
			// 
			// TopSplitter
			// 
			this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopSplitter.Location = new System.Drawing.Point(0, 159);
			this.TopSplitter.Name = "TopSplitter";
			this.TopSplitter.Size = new System.Drawing.Size(487, 3);
			this.TopSplitter.TabIndex = 1;
			this.TopSplitter.TabStop = false;
			// 
			// BPanel
			// 
			this.BPanel.Controls.Add(this.BAPanel);
			this.BPanel.Controls.Add(this.BBPanel);
			this.BPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BPanel.Location = new System.Drawing.Point(0, 162);
			this.BPanel.Name = "BPanel";
			this.BPanel.Size = new System.Drawing.Size(487, 332);
			this.BPanel.TabIndex = 2;
			// 
			// BAPanel
			// 
			this.BAPanel.Controls.Add(this.TargetTextBox);
			this.BAPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BAPanel.Location = new System.Drawing.Point(0, 0);
			this.BAPanel.Name = "BAPanel";
			this.BAPanel.Size = new System.Drawing.Size(487, 284);
			this.BAPanel.TabIndex = 0;
			// 
			// BBPanel
			// 
			this.BBPanel.Controls.Add(this.ProcessButton);
			this.BBPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BBPanel.Location = new System.Drawing.Point(0, 284);
			this.BBPanel.Name = "BBPanel";
			this.BBPanel.Size = new System.Drawing.Size(487, 48);
			this.BBPanel.TabIndex = 2;
			// 
			// SourceTextBox
			// 
			this.SourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SourceTextBox.Location = new System.Drawing.Point(0, 0);
			this.SourceTextBox.Multiline = true;
			this.SourceTextBox.Name = "SourceTextBox";
			this.SourceTextBox.Size = new System.Drawing.Size(487, 159);
			this.SourceTextBox.TabIndex = 0;
			// 
			// TargetTextBox
			// 
			this.TargetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TargetTextBox.Location = new System.Drawing.Point(0, 0);
			this.TargetTextBox.Multiline = true;
			this.TargetTextBox.Name = "TargetTextBox";
			this.TargetTextBox.Size = new System.Drawing.Size(487, 284);
			this.TargetTextBox.TabIndex = 0;
			// 
			// ProcessButton
			// 
			this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessButton.Location = new System.Drawing.Point(400, 13);
			this.ProcessButton.Name = "ProcessButton";
			this.ProcessButton.Size = new System.Drawing.Size(75, 23);
			this.ProcessButton.TabIndex = 0;
			this.ProcessButton.Text = "Process";
			this.ProcessButton.UseVisualStyleBackColor = true;
			this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 494);
			this.Controls.Add(this.BPanel);
			this.Controls.Add(this.TopSplitter);
			this.Controls.Add(this.APanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.APanel.ResumeLayout(false);
			this.APanel.PerformLayout();
			this.BPanel.ResumeLayout(false);
			this.BAPanel.ResumeLayout(false);
			this.BAPanel.PerformLayout();
			this.BBPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APanel;
		private System.Windows.Forms.TextBox SourceTextBox;
		private System.Windows.Forms.Splitter TopSplitter;
		private System.Windows.Forms.Panel BPanel;
		private System.Windows.Forms.Panel BAPanel;
		private System.Windows.Forms.TextBox TargetTextBox;
		private System.Windows.Forms.Panel BBPanel;
		private System.Windows.Forms.Button ProcessButton;
	}
}

