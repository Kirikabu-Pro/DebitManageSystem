﻿namespace DebitManageSystem
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.ClientManageButton = new System.Windows.Forms.Button();
            this.DepartManagebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 19);
            this.textBox1.TabIndex = 0;
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.Location = new System.Drawing.Point(330, 403);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(112, 35);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ClientManageButton
            // 
            this.ClientManageButton.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClientManageButton.Location = new System.Drawing.Point(61, 175);
            this.ClientManageButton.Name = "ClientManageButton";
            this.ClientManageButton.Size = new System.Drawing.Size(126, 45);
            this.ClientManageButton.TabIndex = 2;
            this.ClientManageButton.Text = "取引先管理";
            this.ClientManageButton.UseVisualStyleBackColor = true;
            // 
            // DepartManagebutton
            // 
            this.DepartManagebutton.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DepartManagebutton.Location = new System.Drawing.Point(61, 248);
            this.DepartManagebutton.Name = "DepartManagebutton";
            this.DepartManagebutton.Size = new System.Drawing.Size(126, 46);
            this.DepartManagebutton.TabIndex = 3;
            this.DepartManagebutton.Text = "部門管理";
            this.DepartManagebutton.UseVisualStyleBackColor = true;
            this.DepartManagebutton.Click += new System.EventHandler(this.DepartManagebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "メニュー";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartManagebutton);
            this.Controls.Add(this.ClientManageButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Menu";
            this.Text = "メニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ClientManageButton;
        private System.Windows.Forms.Button DepartManagebutton;
        private System.Windows.Forms.Label label1;
    }
}

