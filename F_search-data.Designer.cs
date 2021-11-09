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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFromSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpToSearch = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(113, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rango de búsqueda";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(395, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(234, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFromSearch
            // 
            this.dtpFromSearch.AllowDrop = true;
            this.dtpFromSearch.CustomFormat = "";
            this.dtpFromSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromSearch.Location = new System.Drawing.Point(233, 76);
            this.dtpFromSearch.Name = "dtpFromSearch";
            this.dtpFromSearch.Size = new System.Drawing.Size(108, 20);
            this.dtpFromSearch.TabIndex = 8;
            this.dtpFromSearch.TabStop = false;
            this.dtpFromSearch.ValueChanged += new System.EventHandler(this.dtpFromSearch_ValueChanged);
            // 
            // dtpToSearch
            // 
            this.dtpToSearch.AllowDrop = true;
            this.dtpToSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToSearch.Location = new System.Drawing.Point(429, 76);
            this.dtpToSearch.Name = "dtpToSearch";
            this.dtpToSearch.Size = new System.Drawing.Size(108, 20);
            this.dtpToSearch.TabIndex = 9;
            this.dtpToSearch.ValueChanged += new System.EventHandler(this.dtpToSearch_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpToSearch);
            this.groupBox1.Controls.Add(this.dtpFromSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(704, 639);
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
            this.btnClear.Location = new System.Drawing.Point(365, 639);
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
            this.Volver.Location = new System.Drawing.Point(30, 639);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(94, 33);
            this.Volver.TabIndex = 14;
            this.Volver.Text = "Volver atrás";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetAll);
            this.groupBox2.Controls.Add(this.lblTo);
            this.groupBox2.Controls.Add(this.lblFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgSearch);
            this.groupBox2.Location = new System.Drawing.Point(30, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 487);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(604, 19);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(154, 23);
            this.btnGetAll.TabIndex = 9;
            this.btnGetAll.Text = "Mostrar todos los registros";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(495, 450);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 13);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "label9";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(495, 421);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 13);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Búsqueda actual";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(305, 412);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de aperturas mostradas:";
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToOrderColumns = true;
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(6, 48);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(753, 308);
            this.dgSearch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprobarConexionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // comprobarConexionToolStripMenuItem
            // 
            this.comprobarConexionToolStripMenuItem.Name = "comprobarConexionToolStripMenuItem";
            this.comprobarConexionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.comprobarConexionToolStripMenuItem.Text = "Comprobar conexion";
            this.comprobarConexionToolStripMenuItem.Click += new System.EventHandler(this.comprobarConexionToolStripMenuItem_Click);
            // 
            // F_search_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_search_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Búsqueda";
            this.Load += new System.EventHandler(this.F_search_data_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFromSearch;
        private System.Windows.Forms.DateTimePicker dtpToSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprobarConexionToolStripMenuItem;
    }
}