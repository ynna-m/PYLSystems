﻿namespace PYLsystems
{
    partial class addSalesConfirm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(263, 161);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 37);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(51, 161);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(130, 37);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelTextLabel
            // 
            this.cancelTextLabel.AutoSize = true;
            this.cancelTextLabel.Location = new System.Drawing.Point(135, 90);
            this.cancelTextLabel.Name = "cancelTextLabel";
            this.cancelTextLabel.Size = new System.Drawing.Size(161, 20);
            this.cancelTextLabel.TabIndex = 4;
            this.cancelTextLabel.Text = "Confirm Sales Order?";
            this.cancelTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addSalesConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 264);
            this.ControlBox = false;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addSalesConfirm";
            this.Text = "addSalesConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label cancelTextLabel;
    }
}