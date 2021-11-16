
namespace ContactBookApp
{
    partial class FrmAddContact
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSaveContact = new System.Windows.Forms.Button();
            this.BtnLightAndDarkTheme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbxTheme = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbxName = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PbxLastName = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblPassword = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.MTxtPersonalPhone = new System.Windows.Forms.MaskedTextBox();
            this.MTxtWorkPhone = new System.Windows.Forms.MaskedTextBox();
            this.PbxAdress = new System.Windows.Forms.PictureBox();
            this.PbxPersonal = new System.Windows.Forms.PictureBox();
            this.PbxWork = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTheme)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxName)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLastName)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxWork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(177)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactBookApp.Properties.Resources.close32;
            this.pictureBox1.Location = new System.Drawing.Point(377, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnSaveContact, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnLightAndDarkTheme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtAdress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MTxtPersonalPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MTxtWorkPhone, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 382);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnSaveContact
            // 
            this.BtnSaveContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaveContact.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnSaveContact, 2);
            this.BtnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveContact.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnSaveContact.Image = global::ContactBookApp.Properties.Resources.save_white;
            this.BtnSaveContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveContact.Location = new System.Drawing.Point(107, 333);
            this.BtnSaveContact.Name = "BtnSaveContact";
            this.BtnSaveContact.Size = new System.Drawing.Size(198, 40);
            this.BtnSaveContact.TabIndex = 5;
            this.BtnSaveContact.Text = "Save Contact";
            this.BtnSaveContact.UseVisualStyleBackColor = true;
            this.BtnSaveContact.Click += new System.EventHandler(this.BtnSaveContact_Click);
            // 
            // BtnLightAndDarkTheme
            // 
            this.BtnLightAndDarkTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLightAndDarkTheme.FlatAppearance.BorderSize = 0;
            this.BtnLightAndDarkTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLightAndDarkTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnLightAndDarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLightAndDarkTheme.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLightAndDarkTheme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLightAndDarkTheme.Location = new System.Drawing.Point(209, 3);
            this.BtnLightAndDarkTheme.Name = "BtnLightAndDarkTheme";
            this.BtnLightAndDarkTheme.Size = new System.Drawing.Size(200, 48);
            this.BtnLightAndDarkTheme.TabIndex = 6;
            this.BtnLightAndDarkTheme.Text = "Light Theme ☀";
            this.BtnLightAndDarkTheme.UseVisualStyleBackColor = true;
            this.BtnLightAndDarkTheme.Click += new System.EventHandler(this.BtnLightAndDarkTheme_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PbxTheme);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 48);
            this.panel2.TabIndex = 7;
            // 
            // PbxTheme
            // 
            this.PbxTheme.Image = global::ContactBookApp.Properties.Resources.theme_white;
            this.PbxTheme.Location = new System.Drawing.Point(44, 15);
            this.PbxTheme.Name = "PbxTheme";
            this.PbxTheme.Size = new System.Drawing.Size(24, 24);
            this.PbxTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxTheme.TabIndex = 9;
            this.PbxTheme.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(74, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Change Theme: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PbxName);
            this.panel3.Controls.Add(this.LblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 48);
            this.panel3.TabIndex = 8;
            // 
            // PbxName
            // 
            this.PbxName.Image = global::ContactBookApp.Properties.Resources.name_white;
            this.PbxName.Location = new System.Drawing.Point(107, 20);
            this.PbxName.Name = "PbxName";
            this.PbxName.Size = new System.Drawing.Size(24, 24);
            this.PbxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxName.TabIndex = 3;
            this.PbxName.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblName.AutoSize = true;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(137, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 19);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PbxLastName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 9;
            // 
            // PbxLastName
            // 
            this.PbxLastName.Image = global::ContactBookApp.Properties.Resources.name_white;
            this.PbxLastName.Location = new System.Drawing.Point(76, 18);
            this.PbxLastName.Name = "PbxLastName";
            this.PbxLastName.Size = new System.Drawing.Size(24, 24);
            this.PbxLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxLastName.TabIndex = 3;
            this.PbxLastName.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PbxAdress);
            this.panel5.Controls.Add(this.LblUserName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 48);
            this.panel5.TabIndex = 10;
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblUserName.AutoSize = true;
            this.LblUserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblUserName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUserName.Location = new System.Drawing.Point(137, 19);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(59, 19);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Adress:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PbxPersonal);
            this.panel6.Controls.Add(this.LblPassword);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 48);
            this.panel6.TabIndex = 11;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPassword.AutoSize = true;
            this.LblPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(75, 17);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(121, 19);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Personal Phone:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.PbxWork);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 273);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 48);
            this.panel7.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work Phone:";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TxtName.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.Location = new System.Drawing.Point(209, 61);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(200, 39);
            this.TxtName.TabIndex = 13;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TxtLastName.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLastName.ForeColor = System.Drawing.Color.White;
            this.TxtLastName.Location = new System.Drawing.Point(209, 115);
            this.TxtLastName.Multiline = true;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(200, 39);
            this.TxtLastName.TabIndex = 14;
            // 
            // TxtAdress
            // 
            this.TxtAdress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TxtAdress.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAdress.ForeColor = System.Drawing.Color.White;
            this.TxtAdress.Location = new System.Drawing.Point(209, 169);
            this.TxtAdress.Multiline = true;
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(200, 39);
            this.TxtAdress.TabIndex = 15;
            // 
            // MTxtPersonalPhone
            // 
            this.MTxtPersonalPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTxtPersonalPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.MTxtPersonalPhone.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTxtPersonalPhone.ForeColor = System.Drawing.Color.White;
            this.MTxtPersonalPhone.Location = new System.Drawing.Point(209, 223);
            this.MTxtPersonalPhone.Mask = "(999) 000-0000";
            this.MTxtPersonalPhone.Name = "MTxtPersonalPhone";
            this.MTxtPersonalPhone.PromptChar = '*';
            this.MTxtPersonalPhone.Size = new System.Drawing.Size(200, 40);
            this.MTxtPersonalPhone.TabIndex = 16;
            // 
            // MTxtWorkPhone
            // 
            this.MTxtWorkPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.MTxtWorkPhone.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTxtWorkPhone.ForeColor = System.Drawing.Color.White;
            this.MTxtWorkPhone.Location = new System.Drawing.Point(209, 273);
            this.MTxtWorkPhone.Mask = "(999) 000-0000";
            this.MTxtWorkPhone.Name = "MTxtWorkPhone";
            this.MTxtWorkPhone.PromptChar = '*';
            this.MTxtWorkPhone.Size = new System.Drawing.Size(200, 40);
            this.MTxtWorkPhone.TabIndex = 17;
            // 
            // PbxAdress
            // 
            this.PbxAdress.Image = global::ContactBookApp.Properties.Resources.adress_white;
            this.PbxAdress.Location = new System.Drawing.Point(115, 22);
            this.PbxAdress.Name = "PbxAdress";
            this.PbxAdress.Size = new System.Drawing.Size(16, 16);
            this.PbxAdress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxAdress.TabIndex = 4;
            this.PbxAdress.TabStop = false;
            // 
            // PbxPersonal
            // 
            this.PbxPersonal.Image = global::ContactBookApp.Properties.Resources.personal_white;
            this.PbxPersonal.Location = new System.Drawing.Point(53, 20);
            this.PbxPersonal.Name = "PbxPersonal";
            this.PbxPersonal.Size = new System.Drawing.Size(16, 16);
            this.PbxPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxPersonal.TabIndex = 4;
            this.PbxPersonal.TabStop = false;
            // 
            // PbxWork
            // 
            this.PbxWork.Image = global::ContactBookApp.Properties.Resources.work_white;
            this.PbxWork.Location = new System.Drawing.Point(74, 23);
            this.PbxWork.Name = "PbxWork";
            this.PbxWork.Size = new System.Drawing.Size(16, 16);
            this.PbxWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxWork.TabIndex = 5;
            this.PbxWork.TabStop = false;
            // 
            // FrmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddContact";
            this.Text = "FrmRegister";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTheme)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxName)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLastName)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSaveContact;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLightAndDarkTheme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox PbxTheme;
        private System.Windows.Forms.PictureBox PbxName;
        private System.Windows.Forms.PictureBox PbxLastName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtLastName;
        public System.Windows.Forms.TextBox TxtAdress;
        public System.Windows.Forms.MaskedTextBox MTxtPersonalPhone;
        public System.Windows.Forms.MaskedTextBox MTxtWorkPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbxAdress;
        private System.Windows.Forms.PictureBox PbxPersonal;
        private System.Windows.Forms.PictureBox PbxWork;
    }
}