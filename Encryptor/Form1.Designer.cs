namespace Encryptor
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
            this.Para = new System.Windows.Forms.TextBox();
            this.Comborot = new System.Windows.Forms.ComboBox();
            this.caesarot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.enbutton = new System.Windows.Forms.Button();
            this.debutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.algo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Para
            // 
            this.Para.Location = new System.Drawing.Point(16, 86);
            this.Para.Multiline = true;
            this.Para.Name = "Para";
            this.Para.Size = new System.Drawing.Size(745, 165);
            this.Para.TabIndex = 0;
            // 
            // Comborot
            // 
            this.Comborot.AllowDrop = true;
            this.Comborot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comborot.FormattingEnabled = true;
            this.Comborot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.Comborot.Location = new System.Drawing.Point(627, 33);
            this.Comborot.Name = "Comborot";
            this.Comborot.Size = new System.Drawing.Size(121, 24);
            this.Comborot.TabIndex = 1;
            this.Comborot.Visible = false;
            this.Comborot.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // caesarot
            // 
            this.caesarot.AutoSize = true;
            this.caesarot.Location = new System.Drawing.Point(624, 13);
            this.caesarot.Name = "caesarot";
            this.caesarot.Size = new System.Drawing.Size(87, 17);
            this.caesarot.TabIndex = 2;
            this.caesarot.Text = "Caesar ROT";
            this.caesarot.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thing to encrypt/decrypt:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result";
            // 
            // result
            // 
            this.result.AcceptsReturn = true;
            this.result.Location = new System.Drawing.Point(12, 275);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(745, 443);
            this.result.TabIndex = 7;
            // 
            // enbutton
            // 
            this.enbutton.Location = new System.Drawing.Point(184, 9);
            this.enbutton.Name = "enbutton";
            this.enbutton.Size = new System.Drawing.Size(86, 43);
            this.enbutton.TabIndex = 8;
            this.enbutton.Text = "Encrypt";
            this.enbutton.UseVisualStyleBackColor = true;
            this.enbutton.Click += new System.EventHandler(this.enbutton_Click);
            // 
            // debutton
            // 
            this.debutton.Location = new System.Drawing.Point(276, 9);
            this.debutton.Name = "debutton";
            this.debutton.Size = new System.Drawing.Size(98, 43);
            this.debutton.TabIndex = 8;
            this.debutton.Text = "Decrypt";
            this.debutton.UseVisualStyleBackColor = true;
            this.debutton.Click += new System.EventHandler(this.debutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Encryption Algorithm";
            // 
            // algo
            // 
            this.algo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algo.FormattingEnabled = true;
            this.algo.Items.AddRange(new object[] {
            "Caesar Cipher"});
            this.algo.Location = new System.Drawing.Point(12, 32);
            this.algo.Name = "algo";
            this.algo.Size = new System.Drawing.Size(121, 24);
            this.algo.TabIndex = 10;
            this.algo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(408, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "All Rots/Figure out decrypt";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 730);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.algo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debutton);
            this.Controls.Add(this.enbutton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caesarot);
            this.Controls.Add(this.Comborot);
            this.Controls.Add(this.Para);
            this.Name = "Form1";
            this.Text = "Encryption/Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Para;
        private System.Windows.Forms.ComboBox Comborot;
        private System.Windows.Forms.Label caesarot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button enbutton;
        private System.Windows.Forms.Button debutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox algo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

