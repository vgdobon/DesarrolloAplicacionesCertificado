namespace AplicacionExcritorio
{
    partial class MyForm
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
            MyLabel = new Label();
            MyBoton = new Button();
            SuspendLayout();
            // 
            // MyLabel
            // 
            MyLabel.Font = new Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyLabel.Location = new Point(27, 21);
            MyLabel.Name = "MyLabel";
            MyLabel.Size = new Size(301, 25);
            MyLabel.TabIndex = 0;
            MyLabel.Text = "Esto es una etiqueta";
            MyLabel.Click += label1_Click;
            // 
            // MyBoton
            // 
            MyBoton.Font = new Font("Segoe UI", 12F);
            MyBoton.Location = new Point(350, 14);
            MyBoton.Name = "MyBoton";
            MyBoton.Size = new Size(207, 38);
            MyBoton.TabIndex = 1;
            MyBoton.Text = "Cambiar fondo";
            MyBoton.UseVisualStyleBackColor = true;
            MyBoton.Click += button1_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MyBoton);
            Controls.Add(MyLabel);
            Enabled = false;
            Name = "MyForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label MyLabel;
        private Button MyBoton;
    }
}
