namespace Clave5_Grupo9
{
    partial class F_enter_data
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
            this.GbClientData = new System.Windows.Forms.GroupBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TbOtherIncome = new System.Windows.Forms.TextBox();
            this.TbIncome = new System.Windows.Forms.TextBox();
            this.TbWorkPlace = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.TbNeighborhood = new System.Windows.Forms.TextBox();
            this.TbHouse = new System.Windows.Forms.TextBox();
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.GbConfirmData = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TbInterestRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbCardsTypes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.GbClientData.SuspendLayout();
            this.GbConfirmData.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbClientData
            // 
            this.GbClientData.Controls.Add(this.DtpDateOfBirth);
            this.GbClientData.Controls.Add(this.TbOtherIncome);
            this.GbClientData.Controls.Add(this.TbIncome);
            this.GbClientData.Controls.Add(this.TbWorkPlace);
            this.GbClientData.Controls.Add(this.TbPhone);
            this.GbClientData.Controls.Add(this.TbCity);
            this.GbClientData.Controls.Add(this.TbNeighborhood);
            this.GbClientData.Controls.Add(this.TbHouse);
            this.GbClientData.Controls.Add(this.TbID);
            this.GbClientData.Controls.Add(this.TbLastName);
            this.GbClientData.Controls.Add(this.TbFirstName);
            this.GbClientData.Controls.Add(this.label7);
            this.GbClientData.Controls.Add(this.label6);
            this.GbClientData.Controls.Add(this.label5);
            this.GbClientData.Controls.Add(this.label4);
            this.GbClientData.Controls.Add(this.label3);
            this.GbClientData.Controls.Add(this.label2);
            this.GbClientData.Controls.Add(this.label1);
            this.GbClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbClientData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbClientData.Location = new System.Drawing.Point(13, 13);
            this.GbClientData.Name = "GbClientData";
            this.GbClientData.Size = new System.Drawing.Size(474, 325);
            this.GbClientData.TabIndex = 0;
            this.GbClientData.TabStop = false;
            this.GbClientData.Text = "Datos del Cliente";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(143, 168);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(318, 20);
            this.DtpDateOfBirth.TabIndex = 23;
            // 
            // TbOtherIncome
            // 
            this.TbOtherIncome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbOtherIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOtherIncome.Location = new System.Drawing.Point(311, 280);
            this.TbOtherIncome.Name = "TbOtherIncome";
            this.TbOtherIncome.Size = new System.Drawing.Size(150, 20);
            this.TbOtherIncome.TabIndex = 20;
            this.TbOtherIncome.Text = "Ingresos Pasivos";
            this.TbOtherIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIncome
            // 
            this.TbIncome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIncome.Location = new System.Drawing.Point(143, 280);
            this.TbIncome.Name = "TbIncome";
            this.TbIncome.Size = new System.Drawing.Size(150, 20);
            this.TbIncome.TabIndex = 19;
            this.TbIncome.Text = "Sueldo o Ingreso Principal";
            this.TbIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbWorkPlace
            // 
            this.TbWorkPlace.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbWorkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbWorkPlace.Location = new System.Drawing.Point(143, 245);
            this.TbWorkPlace.Name = "TbWorkPlace";
            this.TbWorkPlace.Size = new System.Drawing.Size(318, 20);
            this.TbWorkPlace.TabIndex = 18;
            this.TbWorkPlace.Text = "Nombre de la Empresa o Institución";
            this.TbWorkPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbPhone
            // 
            this.TbPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPhone.Location = new System.Drawing.Point(143, 208);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(318, 20);
            this.TbPhone.TabIndex = 17;
            // 
            // TbCity
            // 
            this.TbCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCity.Location = new System.Drawing.Point(143, 131);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(318, 20);
            this.TbCity.TabIndex = 12;
            this.TbCity.Text = "Municipio y/o Departamento";
            this.TbCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbNeighborhood
            // 
            this.TbNeighborhood.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNeighborhood.Location = new System.Drawing.Point(311, 95);
            this.TbNeighborhood.Name = "TbNeighborhood";
            this.TbNeighborhood.Size = new System.Drawing.Size(150, 20);
            this.TbNeighborhood.TabIndex = 11;
            this.TbNeighborhood.Text = "Barrio/Colonia/Residencial";
            this.TbNeighborhood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbHouse
            // 
            this.TbHouse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHouse.Location = new System.Drawing.Point(143, 95);
            this.TbHouse.Name = "TbHouse";
            this.TbHouse.Size = new System.Drawing.Size(150, 20);
            this.TbHouse.TabIndex = 10;
            this.TbHouse.Text = "Casa";
            this.TbHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbID
            // 
            this.TbID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbID.Location = new System.Drawing.Point(143, 59);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(318, 20);
            this.TbID.TabIndex = 9;
            // 
            // TbLastName
            // 
            this.TbLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLastName.Location = new System.Drawing.Point(311, 23);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(150, 20);
            this.TbLastName.TabIndex = 8;
            this.TbLastName.Text = "Apellido/s";
            this.TbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbFirstName
            // 
            this.TbFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFirstName.Location = new System.Drawing.Point(143, 23);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(150, 20);
            this.TbFirstName.TabIndex = 7;
            this.TbFirstName.Text = "Nombre/s";
            this.TbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ingresos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lugar de Trabajo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° de DUI/ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(387, 404);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 23);
            this.BtnNew.TabIndex = 22;
            this.BtnNew.Text = "Nuevo Cliente";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(387, 365);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(100, 23);
            this.BtnConfirm.TabIndex = 21;
            this.BtnConfirm.Text = "Confirmar Datos";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // GbConfirmData
            // 
            this.GbConfirmData.Controls.Add(this.LblStatus);
            this.GbConfirmData.Controls.Add(this.TbInterestRate);
            this.GbConfirmData.Controls.Add(this.label10);
            this.GbConfirmData.Controls.Add(this.CbCardsTypes);
            this.GbConfirmData.Controls.Add(this.label9);
            this.GbConfirmData.Controls.Add(this.label8);
            this.GbConfirmData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConfirmData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbConfirmData.Location = new System.Drawing.Point(12, 344);
            this.GbConfirmData.Name = "GbConfirmData";
            this.GbConfirmData.Size = new System.Drawing.Size(346, 131);
            this.GbConfirmData.TabIndex = 1;
            this.GbConfirmData.TabStop = false;
            this.GbConfirmData.Text = "Confirmación de Datos";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(180, 105);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(41, 13);
            this.LblStatus.TabIndex = 6;
            this.LblStatus.Text = "Vacío";
            // 
            // TbInterestRate
            // 
            this.TbInterestRate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbInterestRate.Location = new System.Drawing.Point(183, 63);
            this.TbInterestRate.Name = "TbInterestRate";
            this.TbInterestRate.Size = new System.Drawing.Size(150, 20);
            this.TbInterestRate.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tasa de Interés a Asignar:";
            // 
            // CbCardsTypes
            // 
            this.CbCardsTypes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CbCardsTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCardsTypes.FormattingEnabled = true;
            this.CbCardsTypes.Items.AddRange(new object[] {
            "Azul",
            "Dorada",
            "Platino"});
            this.CbCardsTypes.Location = new System.Drawing.Point(183, 23);
            this.CbCardsTypes.Name = "CbCardsTypes";
            this.CbCardsTypes.Size = new System.Drawing.Size(150, 21);
            this.CbCardsTypes.TabIndex = 2;
            this.CbCardsTypes.Text = "Elija una opción...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tipo de Tarjetas disponibles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado del Cliente:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(387, 444);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 23);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Volver atrás";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // F_enter_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.GbConfirmData);
            this.Controls.Add(this.GbClientData);
            this.Controls.Add(this.BtnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "F_enter_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Datos";
            this.GbClientData.ResumeLayout(false);
            this.GbClientData.PerformLayout();
            this.GbConfirmData.ResumeLayout(false);
            this.GbConfirmData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbClientData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbWorkPlace;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.TextBox TbNeighborhood;
        private System.Windows.Forms.TextBox TbHouse;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TbOtherIncome;
        private System.Windows.Forms.TextBox TbIncome;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox GbConfirmData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbCardsTypes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TbInterestRate;
        private System.Windows.Forms.Button btnReturn;
    }
}