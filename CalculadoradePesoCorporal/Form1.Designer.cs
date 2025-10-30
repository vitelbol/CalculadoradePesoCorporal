namespace CalculadoradePesoCorporal
{
    partial class Form1
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
            lblPeso = new Label();
            lblAltura = new Label();
            btnCalcular = new Button();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            SuspendLayout();
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(26, 47);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 0;
            lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(26, 88);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(92, 136);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(92, 47);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(92, 88);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 263);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(btnCalcular);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeso;
        private Label lblAltura;
        private Button btnCalcular;
        private TextBox txtPeso;
        private TextBox txtAltura;
    }
}
