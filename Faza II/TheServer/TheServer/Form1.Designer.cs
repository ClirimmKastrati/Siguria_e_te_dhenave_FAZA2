namespace TheServer
{
    partial class Server
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.shkruaj = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(14, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 65);
            this.textBox1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(12, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start the server";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(358, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop the server";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // shkruaj
            // 
            this.shkruaj.AutoSize = true;
            this.shkruaj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shkruaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.shkruaj.Location = new System.Drawing.Point(11, 230);
            this.shkruaj.Name = "shkruaj";
            this.shkruaj.Size = new System.Drawing.Size(121, 14);
            this.shkruaj.TabIndex = 17;
            this.shkruaj.Text = "Shkruaje mesazhin";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.CausesValidation = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEncrypt.Location = new System.Drawing.Point(14, 331);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(69, 31);
            this.btnEncrypt.TabIndex = 16;
            this.btnEncrypt.Text = "Enkripto";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPlaintext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlaintext.Location = new System.Drawing.Point(12, 247);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(449, 78);
            this.txtPlaintext.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.CausesValidation = false;
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(362, 396);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 62);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCiphertext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCiphertext.Location = new System.Drawing.Point(12, 396);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(340, 62);
            this.txtCiphertext.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 162);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 65);
            this.textBox2.TabIndex = 18;
            // 
            // btnDekripto
            // 
            this.btnDekripto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDekripto.CausesValidation = false;
            this.btnDekripto.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDekripto.Location = new System.Drawing.Point(12, 125);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(69, 31);
            this.btnDekripto.TabIndex = 19;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = false;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(14, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mesazhi i enkriptuar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mesazhi i pranuar";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(477, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.shkruaj);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label shkruaj;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

