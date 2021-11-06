namespace Clave5_Grupo9
{
    partial class F_search_data
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCardTypeSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFromSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpToSearch = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStatusSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbxNameSearch
            // 
            this.tbxNameSearch.Location = new System.Drawing.Point(33, 51);
            this.tbxNameSearch.Name = "tbxNameSearch";
            this.tbxNameSearch.Size = new System.Drawing.Size(297, 20);
            this.tbxNameSearch.TabIndex = 1;
            this.tbxNameSearch.TextChanged += new System.EventHandler(this.tbxNameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de tarjeta";
            // 
            // cbxCardTypeSearch
            // 
            this.cbxCardTypeSearch.FormattingEnabled = true;
            this.cbxCardTypeSearch.Location = new System.Drawing.Point(33, 111);
            this.cbxCardTypeSearch.Name = "cbxCardTypeSearch";
            this.cbxCardTypeSearch.Size = new System.Drawing.Size(297, 21);
            this.cbxCardTypeSearch.TabIndex = 4;
            this.cbxCardTypeSearch.SelectedIndexChanged += new System.EventHandler(this.cbxCardTypeSearch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de apertura";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(196, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desde";
            // 
            // dtpFromSearch
            // 
            this.dtpFromSearch.Location = new System.Drawing.Point(33, 190);
            this.dtpFromSearch.Name = "dtpFromSearch";
            this.dtpFromSearch.Size = new System.Drawing.Size(136, 20);
            this.dtpFromSearch.TabIndex = 8;
            this.dtpFromSearch.ValueChanged += new System.EventHandler(this.dtpFromSearch_ValueChanged);
            // 
            // dtpToSearch
            // 
            this.dtpToSearch.AllowDrop = true;
            this.dtpToSearch.Location = new System.Drawing.Point(194, 190);
            this.dtpToSearch.Name = "dtpToSearch";
            this.dtpToSearch.Size = new System.Drawing.Size(136, 20);
            this.dtpToSearch.TabIndex = 9;
            this.dtpToSearch.CloseUp += new System.EventHandler(this.dtpToSearch_CloseUp);
            this.dtpToSearch.ValueChanged += new System.EventHandler(this.dtpToSearch_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Por favor, inserte un término de búsqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStatusSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpToSearch);
            this.groupBox1.Controls.Add(this.dtpFromSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCardTypeSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxNameSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 323);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbxStatusSearch
            // 
            this.cbxStatusSearch.FormattingEnabled = true;
            this.cbxStatusSearch.Location = new System.Drawing.Point(33, 260);
            this.cbxStatusSearch.Name = "cbxStatusSearch";
            this.cbxStatusSearch.Size = new System.Drawing.Size(297, 21);
            this.cbxStatusSearch.TabIndex = 11;
            this.cbxStatusSearch.SelectedIndexChanged += new System.EventHandler(this.cbxStatusSearch_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 377);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(172, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 33);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpiar todo";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.SystemColors.Menu;
            this.Volver.Location = new System.Drawing.Point(28, 377);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(94, 33);
            this.Volver.TabIndex = 14;
            this.Volver.Text = "Volver atrás";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // F_search_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 435);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "F_search_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Búsqueda";
            this.Load += new System.EventHandler(this.F_search_data_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCardTypeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFromSearch;
        private System.Windows.Forms.DateTimePicker dtpToSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxStatusSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Volver;
    }
}