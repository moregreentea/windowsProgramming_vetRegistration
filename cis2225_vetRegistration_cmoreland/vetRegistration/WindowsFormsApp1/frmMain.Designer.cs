namespace cis2255_vetRegistration_cmoreland
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(12, 44);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(57, 13);
            this.lblPetName.TabIndex = 0;
            this.lblPetName.Text = "Pet Name:";
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.Location = new System.Drawing.Point(12, 79);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(68, 13);
            this.lblAnimalType.TabIndex = 1;
            this.lblAnimalType.Text = "Animal Type:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 113);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 148);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(47, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Reason:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(12, 185);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(87, 13);
            this.lblPhoneNum.TabIndex = 4;
            this.lblPhoneNum.Text = "Contact Number:";
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(12, 279);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(112, 13);
            this.lblAppointment.TabIndex = 5;
            this.lblAppointment.Text = "Todays Appointments:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(131, 76);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalType.TabIndex = 7;
            // 
            // cmbReason
            // 
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(131, 145);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(121, 21);
            this.cmbReason.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(131, 41);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(100, 20);
            this.txtPetName.TabIndex = 11;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(131, 182);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 12;
            // 
            // lstAppointments
            // 
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.Location = new System.Drawing.Point(15, 305);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(259, 95);
            this.lstAppointments.TabIndex = 13;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(131, 113);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(121, 20);
            this.dtpBirth.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 412);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblAnimalType);
            this.Controls.Add(this.lblPetName);
            this.Name = "frmMain";
            this.Text = "Vet Registration";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblAnimalType;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnClear;
    }
}

