﻿
namespace EnvioRetorno
{
    partial class frm2
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
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_ok = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(96, 213);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(103, 51);
            this.cmd_cancelar.TabIndex = 1;
            this.cmd_cancelar.Text = "cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // cmd_ok
            // 
            this.cmd_ok.Location = new System.Drawing.Point(205, 213);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(103, 51);
            this.cmd_ok.TabIndex = 2;
            this.cmd_ok.Text = "ok";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(96, 94);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(212, 26);
            this.text_nome.TabIndex = 3;
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 276);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.cmd_ok);
            this.Controls.Add(this.cmd_cancelar);
            this.Name = "frm2";
            this.Text = "frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_ok;
        private System.Windows.Forms.TextBox text_nome;
    }
}