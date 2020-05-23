namespace SimulatorOfLife
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
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.bgameTime = new System.Windows.Forms.Button();
			this.numericDensity = new System.Windows.Forms.NumericUpDown();
			this.label_Dansity = new System.Windows.Forms.Label();
			this.numericSpace = new System.Windows.Forms.NumericUpDown();
			this.label_Space = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericDensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSpace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.bgameTime);
			this.splitContainer1.Panel1.Controls.Add(this.numericDensity);
			this.splitContainer1.Panel1.Controls.Add(this.label_Dansity);
			this.splitContainer1.Panel1.Controls.Add(this.numericSpace);
			this.splitContainer1.Panel1.Controls.Add(this.label_Space);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Size = new System.Drawing.Size(793, 394);
			this.splitContainer1.SplitterDistance = 167;
			this.splitContainer1.TabIndex = 0;
			// 
			// bgameTime
			// 
			this.bgameTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.bgameTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bgameTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bgameTime.Location = new System.Drawing.Point(38, 149);
			this.bgameTime.Name = "bgameTime";
			this.bgameTime.Size = new System.Drawing.Size(75, 43);
			this.bgameTime.TabIndex = 4;
			this.bgameTime.Text = "Start";
			this.bgameTime.UseVisualStyleBackColor = false;
			this.bgameTime.Click += new System.EventHandler(this.bgameTime_Click);
			// 
			// numericDensity
			// 
			this.numericDensity.Location = new System.Drawing.Point(21, 96);
			this.numericDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericDensity.Name = "numericDensity";
			this.numericDensity.Size = new System.Drawing.Size(120, 20);
			this.numericDensity.TabIndex = 3;
			this.numericDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label_Dansity
			// 
			this.label_Dansity.AutoSize = true;
			this.label_Dansity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Dansity.Location = new System.Drawing.Point(26, 75);
			this.label_Dansity.Name = "label_Dansity";
			this.label_Dansity.Size = new System.Drawing.Size(0, 18);
			this.label_Dansity.TabIndex = 2;
			// 
			// numericSpace
			// 
			this.numericSpace.Location = new System.Drawing.Point(21, 28);
			this.numericSpace.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.numericSpace.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericSpace.Name = "numericSpace";
			this.numericSpace.Size = new System.Drawing.Size(120, 20);
			this.numericSpace.TabIndex = 1;
			this.numericSpace.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label_Space
			// 
			this.label_Space.AutoSize = true;
			this.label_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Space.Location = new System.Drawing.Point(26, 7);
			this.label_Space.Name = "label_Space";
			this.label_Space.Size = new System.Drawing.Size(0, 18);
			this.label_Space.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(618, 390);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			// 
			// timer1
			// 
			this.timer1.Interval = 40;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 394);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericDensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSpace)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.NumericUpDown numericSpace;
		private System.Windows.Forms.Label label_Space;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button bgameTime;
		private System.Windows.Forms.NumericUpDown numericDensity;
		private System.Windows.Forms.Label label_Dansity;
		private System.Windows.Forms.Timer timer1;
	}
}

