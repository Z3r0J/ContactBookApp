
namespace ContactBookApp
{
    partial class FrmNotify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotify));
            this.PnInit = new System.Windows.Forms.Panel();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PnInit
            // 
            this.PnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.PnInit.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnInit.Location = new System.Drawing.Point(0, 0);
            this.PnInit.Name = "PnInit";
            this.PnInit.Size = new System.Drawing.Size(350, 10);
            this.PnInit.TabIndex = 0;
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(53)))), ((int)(((byte)(37)))));
            this.BtnContinue.Image = global::ContactBookApp.Properties.Resources._continue;
            this.BtnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContinue.Location = new System.Drawing.Point(89, 161);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(168, 44);
            this.BtnContinue.TabIndex = 1;
            this.BtnContinue.Text = "Continue!";
            this.BtnContinue.UseVisualStyleBackColor = false;
            // 
            // LblMensaje
            // 
            this.LblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.LblMensaje.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMensaje.ForeColor = System.Drawing.Color.White;
            this.LblMensaje.Location = new System.Drawing.Point(12, 35);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(326, 110);
            this.LblMensaje.TabIndex = 2;
            this.LblMensaje.Text = "label1";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 217);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.PnInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotify";
            this.Text = "Notification";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblMensaje;
        public System.Windows.Forms.Button BtnContinue;
        public System.Windows.Forms.Panel PnInit;
    }
}