﻿namespace Random
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtTiradas = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bntLaunch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCaras = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero de tiradas:";
			// 
			// txtTiradas
			// 
			this.txtTiradas.Location = new System.Drawing.Point(189, 39);
			this.txtTiradas.Name = "txtTiradas";
			this.txtTiradas.Size = new System.Drawing.Size(100, 22);
			this.txtTiradas.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// bntLaunch
			// 
			this.bntLaunch.Location = new System.Drawing.Point(310, 76);
			this.bntLaunch.Name = "bntLaunch";
			this.bntLaunch.Size = new System.Drawing.Size(75, 23);
			this.bntLaunch.TabIndex = 3;
			this.bntLaunch.Text = "Lanzar";
			this.bntLaunch.UseVisualStyleBackColor = true;
			this.bntLaunch.Click += new System.EventHandler(this.bntLaunch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Numero de caras:";
			// 
			// txtCaras
			// 
			this.txtCaras.Location = new System.Drawing.Point(189, 77);
			this.txtCaras.Name = "txtCaras";
			this.txtCaras.Size = new System.Drawing.Size(100, 22);
			this.txtCaras.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtCaras);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bntLaunch);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTiradas);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTiradas;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button bntLaunch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCaras;
	}
}

