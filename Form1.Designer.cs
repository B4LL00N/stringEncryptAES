
namespace AEStest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlain = new System.Windows.Forms.TextBox();
            this.tbENC = new System.Windows.Forms.TextBox();
            this.tbDEC = new System.Windows.Forms.TextBox();
            this.btENC = new System.Windows.Forms.Button();
            this.btDEC = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.boxChecker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrypted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "AES Text";
            // 
            // tbPlain
            // 
            this.tbPlain.Location = new System.Drawing.Point(86, 6);
            this.tbPlain.Name = "tbPlain";
            this.tbPlain.Size = new System.Drawing.Size(213, 23);
            this.tbPlain.TabIndex = 3;
            // 
            // tbENC
            // 
            this.tbENC.Location = new System.Drawing.Point(86, 33);
            this.tbENC.Name = "tbENC";
            this.tbENC.Size = new System.Drawing.Size(213, 23);
            this.tbENC.TabIndex = 4;
            // 
            // tbDEC
            // 
            this.tbDEC.Location = new System.Drawing.Point(86, 62);
            this.tbDEC.Name = "tbDEC";
            this.tbDEC.Size = new System.Drawing.Size(213, 23);
            this.tbDEC.TabIndex = 5;
            // 
            // btENC
            // 
            this.btENC.Location = new System.Drawing.Point(305, 6);
            this.btENC.Name = "btENC";
            this.btENC.Size = new System.Drawing.Size(91, 31);
            this.btENC.TabIndex = 6;
            this.btENC.Text = "Encrypt String";
            this.btENC.UseVisualStyleBackColor = true;
            this.btENC.Click += new System.EventHandler(this.btENC_Click);
            // 
            // btDEC
            // 
            this.btDEC.Location = new System.Drawing.Point(305, 49);
            this.btDEC.Name = "btDEC";
            this.btDEC.Size = new System.Drawing.Size(91, 31);
            this.btDEC.TabIndex = 7;
            this.btDEC.Text = "Decrypt String";
            this.btDEC.UseVisualStyleBackColor = true;
            this.btDEC.Click += new System.EventHandler(this.btDEC_Click);
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(402, 6);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(91, 31);
            this.btHelp.TabIndex = 10;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // boxChecker
            // 
            this.boxChecker.Enabled = true;
            this.boxChecker.Tick += new System.EventHandler(this.boxChecker_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Boxes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 96);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btDEC);
            this.Controls.Add(this.btENC);
            this.Controls.Add(this.tbDEC);
            this.Controls.Add(this.tbENC);
            this.Controls.Add(this.tbPlain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Encrypt String to AES by crinobaka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlain;
        private System.Windows.Forms.TextBox tbENC;
        private System.Windows.Forms.TextBox tbDEC;
        private System.Windows.Forms.Button btENC;
        private System.Windows.Forms.Button btDEC;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Timer boxChecker;
        private System.Windows.Forms.Button button1;
    }
}

