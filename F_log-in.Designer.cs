
namespace Clave5_Grupo9
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
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(235, 202);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(312, 26);
            this.TbPassword.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(352, 34);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(66, 18);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contrasena";
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(235, 78);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(312, 20);
            this.TbUser.TabIndex = 0;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogIn.Location = new System.Drawing.Point(239, 314);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(126, 27);
            this.BtnLogIn.TabIndex = 2;
            this.BtnLogIn.Text = "Iniciar sesion";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(447, 314);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(126, 27);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.TbPassword);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TbPassword;
    private System.Windows.Forms.Label lbUser;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TbUser;
    private System.Windows.Forms.Button BtnLogIn;
    private System.Windows.Forms.Button BtnExit;
  }
}

