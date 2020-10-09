namespace Practica_3
{
    partial class Calculadora
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnReset);
            this.gbxBotones.Controls.Add(this.btnPunto);
            this.gbxBotones.Controls.Add(this.btnDiv);
            this.gbxBotones.Controls.Add(this.btnmult);
            this.gbxBotones.Controls.Add(this.btnminus);
            this.gbxBotones.Controls.Add(this.btnplus);
            this.gbxBotones.Controls.Add(this.btnigual);
            this.gbxBotones.Controls.Add(this.btn0);
            this.gbxBotones.Controls.Add(this.btn3);
            this.gbxBotones.Controls.Add(this.btn2);
            this.gbxBotones.Controls.Add(this.btn1);
            this.gbxBotones.Controls.Add(this.btn6);
            this.gbxBotones.Controls.Add(this.btn5);
            this.gbxBotones.Controls.Add(this.btn4);
            this.gbxBotones.Controls.Add(this.btn9);
            this.gbxBotones.Controls.Add(this.btn8);
            this.gbxBotones.Controls.Add(this.btn7);
            this.gbxBotones.Location = new System.Drawing.Point(12, 120);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(305, 286);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Botones";
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(5, 226);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(68, 56);
            this.btnPunto.TabIndex = 15;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(227, 102);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(68, 56);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(227, 40);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(68, 56);
            this.btnmult.TabIndex = 13;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(227, 226);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(68, 56);
            this.btnminus.TabIndex = 12;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(227, 164);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(68, 56);
            this.btnplus.TabIndex = 11;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(153, 226);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(68, 56);
            this.btnigual.TabIndex = 10;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(79, 226);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(68, 56);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(153, 164);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 56);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(79, 164);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 56);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(5, 164);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 56);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(153, 102);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 56);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(79, 102);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 56);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(5, 102);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 56);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(153, 40);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 56);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(79, 40);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 56);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(5, 40);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 56);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(305, 102);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(196, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 25);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 425);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.gbxBotones);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnigual;
        public System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnReset;
    }
}

