﻿namespace Clave5_Grupo9
{
    partial class F_option
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
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.processOptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(24, 24);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(125, 50);
            this.BtnEnter.TabIndex = 0;
            this.BtnEnter.Text = "Ingresar Datos";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(181, 24);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(125, 50);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Buscar Datos";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // processOptBtn
            // 
            this.processOptBtn.Location = new System.Drawing.Point(346, 24);
            this.processOptBtn.Name = "processOptBtn";
            this.processOptBtn.Size = new System.Drawing.Size(125, 50);
            this.processOptBtn.TabIndex = 2;
            this.processOptBtn.Text = "Procesar Tarjeta";
            this.processOptBtn.UseVisualStyleBackColor = true;
            // 
            // F_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 96);
            this.Controls.Add(this.processOptBtn);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnEnter);
            this.Name = "F_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Qué acción desea realizar?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button processOptBtn;
    }
}