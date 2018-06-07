namespace TheClient
{
    partial class Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.shkruaj = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPrano = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.CausesValidation = false;
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(364, 173);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 62);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCiphertext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCiphertext.Location = new System.Drawing.Point(15, 173);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(340, 62);
            this.txtCiphertext.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(18, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 73);
            this.textBox1.TabIndex = 3;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlaintext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlaintext.Location = new System.Drawing.Point(9, 26);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(449, 78);
            this.txtPlaintext.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.CausesValidation = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 110);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(69, 31);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Enkripto";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.enkripto_Click);
            // 
            // shkruaj
            // 
            this.shkruaj.AutoSize = true;
            this.shkruaj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shkruaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.shkruaj.Location = new System.Drawing.Point(12, 9);
            this.shkruaj.Name = "shkruaj";
            this.shkruaj.Size = new System.Drawing.Size(121, 14);
            this.shkruaj.TabIndex = 11;
            this.shkruaj.Text = "Shkruaje mesazhin";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerate.CausesValidation = false;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(538, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 26);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Gjenero RSA Parametrat";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.gjenero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(558, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "RSA Parametrat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(489, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "P";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(494, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(494, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(492, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Q";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(522, 150);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(205, 20);
            this.txtP.TabIndex = 21;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(525, 198);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(205, 20);
            this.txtQ.TabIndex = 22;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(525, 255);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(205, 20);
            this.txtE.TabIndex = 23;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(525, 314);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(205, 20);
            this.txtD.TabIndex = 24;
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDekripto.CausesValidation = false;
            this.btnDekripto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDekripto.Location = new System.Drawing.Point(15, 351);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(69, 31);
            this.btnDekripto.TabIndex = 25;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = false;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(18, 388);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(449, 73);
            this.textBox2.TabIndex = 26;
            // 
            // btnPrano
            // 
            this.btnPrano.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrano.CausesValidation = false;
            this.btnPrano.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrano.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrano.Location = new System.Drawing.Point(390, 351);
            this.btnPrano.Name = "btnPrano";
            this.btnPrano.Size = new System.Drawing.Size(74, 31);
            this.btnPrano.TabIndex = 27;
            this.btnPrano.Text = "Prano";
            this.btnPrano.UseVisualStyleBackColor = false;
            this.btnPrano.Click += new System.EventHandler(this.btnPrano_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(15, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mesazhi i enkriptuar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mesazhi i pranuar nga serveri";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrano);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.shkruaj);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.textBox1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label shkruaj;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPrano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

