
namespace EncryptionTool
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
            this.usernamelbl = new System.Windows.Forms.Label();
            this.groupname_txt = new System.Windows.Forms.TextBox();
            this.userpwdlbl = new System.Windows.Forms.Label();
            this.expand_txt = new System.Windows.Forms.TextBox();
            this.ipslbl = new System.Windows.Forms.Label();
            this.ips_rtx = new System.Windows.Forms.RichTextBox();
            this.resultlab = new System.Windows.Forms.Label();
            this.resultrtx = new System.Windows.Forms.RichTextBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.genernatekeybtn = new System.Windows.Forms.Button();
            this.publickey_lbl = new System.Windows.Forms.Label();
            this.publickey_txt = new System.Windows.Forms.TextBox();
            this.privatekey_lbl = new System.Windows.Forms.Label();
            this.privatekey_txt = new System.Windows.Forms.TextBox();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_lbl = new System.Windows.Forms.Label();
            this.decrypt_rtx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(50, 26);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(92, 17);
            this.usernamelbl.TabIndex = 0;
            this.usernamelbl.Text = "GroupName：";
            // 
            // groupname_txt
            // 
            this.groupname_txt.Location = new System.Drawing.Point(129, 20);
            this.groupname_txt.Name = "groupname_txt";
            this.groupname_txt.Size = new System.Drawing.Size(358, 23);
            this.groupname_txt.TabIndex = 1;
            // 
            // userpwdlbl
            // 
            this.userpwdlbl.AutoSize = true;
            this.userpwdlbl.Location = new System.Drawing.Point(50, 179);
            this.userpwdlbl.Name = "userpwdlbl";
            this.userpwdlbl.Size = new System.Drawing.Size(82, 17);
            this.userpwdlbl.TabIndex = 2;
            this.userpwdlbl.Text = "ExpandList：";
            // 
            // expand_txt
            // 
            this.expand_txt.Location = new System.Drawing.Point(129, 173);
            this.expand_txt.Name = "expand_txt";
            this.expand_txt.Size = new System.Drawing.Size(358, 23);
            this.expand_txt.TabIndex = 3;
            // 
            // ipslbl
            // 
            this.ipslbl.AutoSize = true;
            this.ipslbl.Location = new System.Drawing.Point(51, 72);
            this.ipslbl.Name = "ipslbl";
            this.ipslbl.Size = new System.Drawing.Size(50, 17);
            this.ipslbl.TabIndex = 4;
            this.ipslbl.Text = "IPList：";
            // 
            // ips_rtx
            // 
            this.ips_rtx.Location = new System.Drawing.Point(129, 69);
            this.ips_rtx.Name = "ips_rtx";
            this.ips_rtx.Size = new System.Drawing.Size(358, 77);
            this.ips_rtx.TabIndex = 5;
            this.ips_rtx.Text = "";
            // 
            // resultlab
            // 
            this.resultlab.AutoSize = true;
            this.resultlab.Location = new System.Drawing.Point(50, 308);
            this.resultlab.Name = "resultlab";
            this.resultlab.Size = new System.Drawing.Size(68, 17);
            this.resultlab.TabIndex = 6;
            this.resultlab.Text = "加密结果：";
            // 
            // resultrtx
            // 
            this.resultrtx.Location = new System.Drawing.Point(129, 308);
            this.resultrtx.Name = "resultrtx";
            this.resultrtx.Size = new System.Drawing.Size(358, 116);
            this.resultrtx.TabIndex = 7;
            this.resultrtx.Text = "";
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(277, 585);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(82, 32);
            this.encrypt_btn.TabIndex = 8;
            this.encrypt_btn.Text = "加密";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(51, 585);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(82, 32);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "重置";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // genernatekeybtn
            // 
            this.genernatekeybtn.Location = new System.Drawing.Point(165, 585);
            this.genernatekeybtn.Name = "genernatekeybtn";
            this.genernatekeybtn.Size = new System.Drawing.Size(82, 32);
            this.genernatekeybtn.TabIndex = 10;
            this.genernatekeybtn.Text = "生成公私钥";
            this.genernatekeybtn.UseVisualStyleBackColor = true;
            this.genernatekeybtn.Click += new System.EventHandler(this.genernatekeybtn_Click);
            // 
            // publickey_lbl
            // 
            this.publickey_lbl.AutoSize = true;
            this.publickey_lbl.Location = new System.Drawing.Point(50, 226);
            this.publickey_lbl.Name = "publickey_lbl";
            this.publickey_lbl.Size = new System.Drawing.Size(68, 17);
            this.publickey_lbl.TabIndex = 11;
            this.publickey_lbl.Text = "加密公钥：";
            // 
            // publickey_txt
            // 
            this.publickey_txt.Location = new System.Drawing.Point(129, 220);
            this.publickey_txt.Name = "publickey_txt";
            this.publickey_txt.Size = new System.Drawing.Size(358, 23);
            this.publickey_txt.TabIndex = 12;
            // 
            // privatekey_lbl
            // 
            this.privatekey_lbl.AutoSize = true;
            this.privatekey_lbl.Location = new System.Drawing.Point(50, 262);
            this.privatekey_lbl.Name = "privatekey_lbl";
            this.privatekey_lbl.Size = new System.Drawing.Size(68, 17);
            this.privatekey_lbl.TabIndex = 13;
            this.privatekey_lbl.Text = "解密私钥：";
            // 
            // privatekey_txt
            // 
            this.privatekey_txt.Location = new System.Drawing.Point(129, 262);
            this.privatekey_txt.Name = "privatekey_txt";
            this.privatekey_txt.Size = new System.Drawing.Size(358, 23);
            this.privatekey_txt.TabIndex = 14;
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(389, 585);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(82, 32);
            this.decrypt_btn.TabIndex = 15;
            this.decrypt_btn.Text = "解密";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // decrypt_lbl
            // 
            this.decrypt_lbl.AutoSize = true;
            this.decrypt_lbl.Location = new System.Drawing.Point(50, 451);
            this.decrypt_lbl.Name = "decrypt_lbl";
            this.decrypt_lbl.Size = new System.Drawing.Size(68, 17);
            this.decrypt_lbl.TabIndex = 16;
            this.decrypt_lbl.Text = "解密结果：";
            // 
            // decrypt_rtx
            // 
            this.decrypt_rtx.Location = new System.Drawing.Point(129, 448);
            this.decrypt_rtx.Name = "decrypt_rtx";
            this.decrypt_rtx.Size = new System.Drawing.Size(358, 116);
            this.decrypt_rtx.TabIndex = 17;
            this.decrypt_rtx.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 652);
            this.Controls.Add(this.decrypt_rtx);
            this.Controls.Add(this.decrypt_lbl);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.privatekey_txt);
            this.Controls.Add(this.privatekey_lbl);
            this.Controls.Add(this.publickey_txt);
            this.Controls.Add(this.publickey_lbl);
            this.Controls.Add(this.genernatekeybtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.resultrtx);
            this.Controls.Add(this.resultlab);
            this.Controls.Add(this.ips_rtx);
            this.Controls.Add(this.ipslbl);
            this.Controls.Add(this.expand_txt);
            this.Controls.Add(this.userpwdlbl);
            this.Controls.Add(this.groupname_txt);
            this.Controls.Add(this.usernamelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "加密工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.TextBox groupname_txt;
        private System.Windows.Forms.Label userpwdlbl;
        private System.Windows.Forms.TextBox expand_txt;
        private System.Windows.Forms.Label ipslbl;
        private System.Windows.Forms.RichTextBox ips_rtx;
        private System.Windows.Forms.Label resultlab;
        private System.Windows.Forms.RichTextBox resultrtx;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button genernatekeybtn;
        private System.Windows.Forms.Label publickey_lbl;
        private System.Windows.Forms.TextBox publickey_txt;
        private System.Windows.Forms.Label privatekey_lbl;
        private System.Windows.Forms.TextBox privatekey_txt;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label decrypt_lbl;
        private System.Windows.Forms.RichTextBox decrypt_rtx;
    }
}

