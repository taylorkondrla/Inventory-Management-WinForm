namespace C968_Kondrla
{
    partial class ModifyPart
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
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.rdbtnModifyPartInHouse = new System.Windows.Forms.RadioButton();
            this.rdbtnModifyPartOutsourced = new System.Windows.Forms.RadioButton();
            this.ModPartIDLabel = new System.Windows.Forms.Label();
            this.ModPartNameLabel = new System.Windows.Forms.Label();
            this.ModPartInventoryLabel = new System.Windows.Forms.Label();
            this.ModPartPriceLabel = new System.Windows.Forms.Label();
            this.ModPartMaxLabel = new System.Windows.Forms.Label();
            this.ModPartMinLabel = new System.Windows.Forms.Label();
            this.ModPartMachineIDLabel = new System.Windows.Forms.Label();
            this.ModPartIDText = new System.Windows.Forms.TextBox();
            this.ModPartNameText = new System.Windows.Forms.TextBox();
            this.ModPartInventoryText = new System.Windows.Forms.TextBox();
            this.ModPartPriceText = new System.Windows.Forms.TextBox();
            this.ModPartMaxText = new System.Windows.Forms.TextBox();
            this.ModPartMinText = new System.Windows.Forms.TextBox();
            this.ModPartMachineIDText = new System.Windows.Forms.TextBox();
            this.btnModPartSave = new System.Windows.Forms.Button();
            this.btnModPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(33, 54);
            this.ModifyPartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(88, 20);
            this.ModifyPartLabel.TabIndex = 0;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // rdbtnModifyPartInHouse
            // 
            this.rdbtnModifyPartInHouse.AutoSize = true;
            this.rdbtnModifyPartInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnModifyPartInHouse.Location = new System.Drawing.Point(168, 50);
            this.rdbtnModifyPartInHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnModifyPartInHouse.Name = "rdbtnModifyPartInHouse";
            this.rdbtnModifyPartInHouse.Size = new System.Drawing.Size(92, 24);
            this.rdbtnModifyPartInHouse.TabIndex = 1;
            this.rdbtnModifyPartInHouse.TabStop = true;
            this.rdbtnModifyPartInHouse.Text = "In House";
            this.rdbtnModifyPartInHouse.UseVisualStyleBackColor = true;
            this.rdbtnModifyPartInHouse.CheckedChanged += new System.EventHandler(this.rdbtnModifyPartInHouse_CheckedChanged);
            // 
            // rdbtnModifyPartOutsourced
            // 
            this.rdbtnModifyPartOutsourced.AutoSize = true;
            this.rdbtnModifyPartOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnModifyPartOutsourced.Location = new System.Drawing.Point(315, 50);
            this.rdbtnModifyPartOutsourced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnModifyPartOutsourced.Name = "rdbtnModifyPartOutsourced";
            this.rdbtnModifyPartOutsourced.Size = new System.Drawing.Size(110, 24);
            this.rdbtnModifyPartOutsourced.TabIndex = 2;
            this.rdbtnModifyPartOutsourced.TabStop = true;
            this.rdbtnModifyPartOutsourced.Text = "Outsourced";
            this.rdbtnModifyPartOutsourced.UseVisualStyleBackColor = true;
            this.rdbtnModifyPartOutsourced.CheckedChanged += new System.EventHandler(this.rdbtnModifyPartOutsourced_CheckedChanged);
            // 
            // ModPartIDLabel
            // 
            this.ModPartIDLabel.AutoSize = true;
            this.ModPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartIDLabel.Location = new System.Drawing.Point(64, 118);
            this.ModPartIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartIDLabel.Name = "ModPartIDLabel";
            this.ModPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.ModPartIDLabel.TabIndex = 3;
            this.ModPartIDLabel.Text = "ID";
            // 
            // ModPartNameLabel
            // 
            this.ModPartNameLabel.AutoSize = true;
            this.ModPartNameLabel.Location = new System.Drawing.Point(64, 164);
            this.ModPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartNameLabel.Name = "ModPartNameLabel";
            this.ModPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.ModPartNameLabel.TabIndex = 4;
            this.ModPartNameLabel.Text = "Name";
            // 
            // ModPartInventoryLabel
            // 
            this.ModPartInventoryLabel.AutoSize = true;
            this.ModPartInventoryLabel.Location = new System.Drawing.Point(64, 210);
            this.ModPartInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartInventoryLabel.Name = "ModPartInventoryLabel";
            this.ModPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.ModPartInventoryLabel.TabIndex = 5;
            this.ModPartInventoryLabel.Text = "Inventory";
            // 
            // ModPartPriceLabel
            // 
            this.ModPartPriceLabel.AutoSize = true;
            this.ModPartPriceLabel.Location = new System.Drawing.Point(64, 259);
            this.ModPartPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartPriceLabel.Name = "ModPartPriceLabel";
            this.ModPartPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.ModPartPriceLabel.TabIndex = 6;
            this.ModPartPriceLabel.Text = "Price / Cost";
            // 
            // ModPartMaxLabel
            // 
            this.ModPartMaxLabel.AutoSize = true;
            this.ModPartMaxLabel.Location = new System.Drawing.Point(64, 323);
            this.ModPartMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartMaxLabel.Name = "ModPartMaxLabel";
            this.ModPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.ModPartMaxLabel.TabIndex = 7;
            this.ModPartMaxLabel.Text = "Max";
            // 
            // ModPartMinLabel
            // 
            this.ModPartMinLabel.AutoSize = true;
            this.ModPartMinLabel.Location = new System.Drawing.Point(277, 323);
            this.ModPartMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartMinLabel.Name = "ModPartMinLabel";
            this.ModPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.ModPartMinLabel.TabIndex = 8;
            this.ModPartMinLabel.Text = "Min";
            // 
            // ModPartMachineIDLabel
            // 
            this.ModPartMachineIDLabel.AutoSize = true;
            this.ModPartMachineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartMachineIDLabel.Location = new System.Drawing.Point(64, 391);
            this.ModPartMachineIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModPartMachineIDLabel.Name = "ModPartMachineIDLabel";
            this.ModPartMachineIDLabel.Size = new System.Drawing.Size(90, 20);
            this.ModPartMachineIDLabel.TabIndex = 9;
            this.ModPartMachineIDLabel.Text = "Machine ID";
            // 
            // ModPartIDText
            // 
            this.ModPartIDText.Location = new System.Drawing.Point(152, 118);
            this.ModPartIDText.Name = "ModPartIDText";
            this.ModPartIDText.Size = new System.Drawing.Size(273, 26);
            this.ModPartIDText.TabIndex = 10;
            // 
            // ModPartNameText
            // 
            this.ModPartNameText.Location = new System.Drawing.Point(151, 168);
            this.ModPartNameText.Name = "ModPartNameText";
            this.ModPartNameText.Size = new System.Drawing.Size(273, 26);
            this.ModPartNameText.TabIndex = 11;
            // 
            // ModPartInventoryText
            // 
            this.ModPartInventoryText.Location = new System.Drawing.Point(152, 214);
            this.ModPartInventoryText.Name = "ModPartInventoryText";
            this.ModPartInventoryText.Size = new System.Drawing.Size(272, 26);
            this.ModPartInventoryText.TabIndex = 12;
            // 
            // ModPartPriceText
            // 
            this.ModPartPriceText.Location = new System.Drawing.Point(157, 258);
            this.ModPartPriceText.Name = "ModPartPriceText";
            this.ModPartPriceText.Size = new System.Drawing.Size(267, 26);
            this.ModPartPriceText.TabIndex = 13;
            // 
            // ModPartMaxText
            // 
            this.ModPartMaxText.Location = new System.Drawing.Point(115, 324);
            this.ModPartMaxText.Name = "ModPartMaxText";
            this.ModPartMaxText.Size = new System.Drawing.Size(99, 26);
            this.ModPartMaxText.TabIndex = 14;
            // 
            // ModPartMinText
            // 
            this.ModPartMinText.Location = new System.Drawing.Point(338, 323);
            this.ModPartMinText.Name = "ModPartMinText";
            this.ModPartMinText.Size = new System.Drawing.Size(87, 26);
            this.ModPartMinText.TabIndex = 15;
            // 
            // ModPartMachineIDText
            // 
            this.ModPartMachineIDText.Location = new System.Drawing.Point(196, 386);
            this.ModPartMachineIDText.Name = "ModPartMachineIDText";
            this.ModPartMachineIDText.Size = new System.Drawing.Size(228, 26);
            this.ModPartMachineIDText.TabIndex = 16;
            // 
            // btnModPartSave
            // 
            this.btnModPartSave.Location = new System.Drawing.Point(97, 458);
            this.btnModPartSave.Name = "btnModPartSave";
            this.btnModPartSave.Size = new System.Drawing.Size(116, 37);
            this.btnModPartSave.TabIndex = 17;
            this.btnModPartSave.Text = "Save";
            this.btnModPartSave.UseVisualStyleBackColor = true;
            this.btnModPartSave.Click += new System.EventHandler(this.btnModPartSave_Click);
            // 
            // btnModPartCancel
            // 
            this.btnModPartCancel.Location = new System.Drawing.Point(281, 458);
            this.btnModPartCancel.Name = "btnModPartCancel";
            this.btnModPartCancel.Size = new System.Drawing.Size(142, 37);
            this.btnModPartCancel.TabIndex = 18;
            this.btnModPartCancel.Text = "Cancel";
            this.btnModPartCancel.UseVisualStyleBackColor = true;
            this.btnModPartCancel.Click += new System.EventHandler(this.btnModPartCancel_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(530, 586);
            this.Controls.Add(this.btnModPartCancel);
            this.Controls.Add(this.btnModPartSave);
            this.Controls.Add(this.ModPartMachineIDText);
            this.Controls.Add(this.ModPartMinText);
            this.Controls.Add(this.ModPartMaxText);
            this.Controls.Add(this.ModPartPriceText);
            this.Controls.Add(this.ModPartInventoryText);
            this.Controls.Add(this.ModPartNameText);
            this.Controls.Add(this.ModPartIDText);
            this.Controls.Add(this.ModPartMachineIDLabel);
            this.Controls.Add(this.ModPartMinLabel);
            this.Controls.Add(this.ModPartMaxLabel);
            this.Controls.Add(this.ModPartPriceLabel);
            this.Controls.Add(this.ModPartInventoryLabel);
            this.Controls.Add(this.ModPartNameLabel);
            this.Controls.Add(this.ModPartIDLabel);
            this.Controls.Add(this.rdbtnModifyPartOutsourced);
            this.Controls.Add(this.rdbtnModifyPartInHouse);
            this.Controls.Add(this.ModifyPartLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.RadioButton rdbtnModifyPartInHouse;
        private System.Windows.Forms.RadioButton rdbtnModifyPartOutsourced;
        private System.Windows.Forms.Label ModPartIDLabel;
        private System.Windows.Forms.Label ModPartNameLabel;
        private System.Windows.Forms.Label ModPartInventoryLabel;
        private System.Windows.Forms.Label ModPartPriceLabel;
        private System.Windows.Forms.Label ModPartMaxLabel;
        private System.Windows.Forms.Label ModPartMinLabel;
        private System.Windows.Forms.Label ModPartMachineIDLabel;
        private System.Windows.Forms.TextBox ModPartIDText;
        private System.Windows.Forms.TextBox ModPartNameText;
        private System.Windows.Forms.TextBox ModPartInventoryText;
        private System.Windows.Forms.TextBox ModPartPriceText;
        private System.Windows.Forms.TextBox ModPartMaxText;
        private System.Windows.Forms.TextBox ModPartMinText;
        private System.Windows.Forms.TextBox ModPartMachineIDText;
        private System.Windows.Forms.Button btnModPartSave;
        private System.Windows.Forms.Button btnModPartCancel;
    }
}