namespace FilmListaWindowsForms
{
	partial class FilmListaForm
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
			this.FilmBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Årtal = new System.Windows.Forms.Label();
			this.Längd = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FilmBild = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.FilmBild)).BeginInit();
			this.SuspendLayout();
			// 
			// FilmBox
			// 
			this.FilmBox.FormattingEnabled = true;
			this.FilmBox.Location = new System.Drawing.Point(207, 28);
			this.FilmBox.Name = "FilmBox";
			this.FilmBox.Size = new System.Drawing.Size(175, 21);
			this.FilmBox.TabIndex = 0;
			this.FilmBox.SelectedIndexChanged += new System.EventHandler(this.FilmBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(176, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Film:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(173, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Årtal:";
			// 
			// Årtal
			// 
			this.Årtal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Årtal.Location = new System.Drawing.Point(207, 65);
			this.Årtal.Name = "Årtal";
			this.Årtal.Size = new System.Drawing.Size(175, 23);
			this.Årtal.TabIndex = 3;
			this.Årtal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Längd
			// 
			this.Längd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Längd.Location = new System.Drawing.Point(207, 107);
			this.Längd.Name = "Längd";
			this.Längd.Size = new System.Drawing.Size(175, 23);
			this.Längd.TabIndex = 5;
			this.Längd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(164, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Längd:";
			// 
			// FilmBild
			// 
			this.FilmBild.Location = new System.Drawing.Point(179, 159);
			this.FilmBild.Name = "FilmBild";
			this.FilmBild.Size = new System.Drawing.Size(250, 250);
			this.FilmBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FilmBild.TabIndex = 6;
			this.FilmBild.TabStop = false;
			// 
			// FilmListaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 521);
			this.Controls.Add(this.FilmBild);
			this.Controls.Add(this.Längd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Årtal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FilmBox);
			this.Name = "FilmListaForm";
			this.Text = "Film Tajm";
			((System.ComponentModel.ISupportInitialize)(this.FilmBild)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox FilmBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Årtal;
		private System.Windows.Forms.Label Längd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox FilmBild;
	}
}

