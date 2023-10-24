namespace Practica_7
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
            label1 = new Label();
            label2 = new Label();
            Valor = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            Resultado = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 49);
            label2.Name = "label2";
            label2.Size = new Size(238, 36);
            label2.TabIndex = 1;
            label2.Text = "Ingresa el valor:";
            label2.Click += label2_Click;
            // 
            // Valor
            // 
            Valor.Location = new Point(292, 46);
            Valor.Name = "Valor";
            Valor.Size = new Size(200, 39);
            Valor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 123);
            label3.Name = "label3";
            label3.Size = new Size(361, 36);
            label3.TabIndex = 3;
            label3.Text = "Opciones de conversion:";
            // 
            // button1
            // 
            button1.Location = new Point(65, 182);
            button1.Name = "button1";
            button1.Size = new Size(200, 68);
            button1.TabIndex = 4;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(504, 182);
            button2.Name = "button2";
            button2.Size = new Size(209, 68);
            button2.TabIndex = 5;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(315, 223);
            button3.Name = "button3";
            button3.Size = new Size(150, 82);
            button3.TabIndex = 6;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 319);
            label4.Name = "label4";
            label4.Size = new Size(313, 36);
            label4.TabIndex = 7;
            label4.Text = "Resultado en grados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 373);
            label5.Name = "label5";
            label5.Size = new Size(335, 36);
            label5.TabIndex = 8;
            label5.Text = "Equivalente en grados:";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(357, 370);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(200, 39);
            Resultado.TabIndex = 9;
            Resultado.TextChanged += Resultado_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(563, 369);
            label6.Name = "label6";
            label6.Size = new Size(129, 37);
            label6.TabIndex = 10;
            label6.Text = "Grados";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Valor;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox Resultado;
        private Label label6;
    }
}