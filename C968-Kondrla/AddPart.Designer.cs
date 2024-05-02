namespace C968_Kondrla
{
    partial class AddPart
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.rdbtnPartInHouse = new System.Windows.Forms.RadioButton();
            this.rdbtnPartOutsourced = new System.Windows.Forms.RadioButton();
            this.AddPartIDLabel = new System.Windows.Forms.Label();
            this.AddPartNameLabel = new System.Windows.Forms.Label();
            this.AddPartInventoryLabel = new System.Windows.Forms.Label();
            this.AddPartPriceLabel = new System.Windows.Forms.Label();
            this.AddPartMaxLabel = new System.Windows.Forms.Label();
            this.AddPartMinLabel = new System.Windows.Forms.Label();
            this.AddPartMachineIDLabel = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textIDAddPart = new System.Windows.Forms.TextBox();
            this.textNameAddPart = new System.Windows.Forms.TextBox();
            this.textInventoryAddPart = new System.Windows.Forms.TextBox();
            this.textPriceAddPart = new System.Windows.Forms.TextBox();
            this.textMaxAddPart = new System.Windows.Forms.TextBox();
            this.textMinAddPart = new System.Windows.Forms.TextBox();
            this.textMachineIDAddPart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Location = new System.Drawing.Point(21, 40);
            this.addPartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(71, 20);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // rdbtnPartInHouse
            // 
            this.rdbtnPartInHouse.AutoSize = true;
            this.rdbtnPartInHouse.Location = new System.Drawing.Point(124, 36);
            this.rdbtnPartInHouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnPartInHouse.Name = "rdbtnPartInHouse";
            this.rdbtnPartInHouse.Size = new System.Drawing.Size(92, 24);
            this.rdbtnPartInHouse.TabIndex = 1;
            this.rdbtnPartInHouse.TabStop = true;
            this.rdbtnPartInHouse.Text = "In House";
            this.rdbtnPartInHouse.UseVisualStyleBackColor = true;
            this.rdbtnPartInHouse.CheckedChanged += new System.EventHandler(this.rdbtnPartInHouse_CheckedChanged);
            // 
            // rdbtnPartOutsourced
            // 
            this.rdbtnPartOutsourced.AutoSize = true;
            this.rdbtnPartOutsourced.Location = new System.Drawing.Point(239, 36);
            this.rdbtnPartOutsourced.Name = "rdbtnPartOutsourced";
            this.rdbtnPartOutsourced.Size = new System.Drawing.Size(110, 24);
            this.rdbtnPartOutsourced.TabIndex = 2;
            this.rdbtnPartOutsourced.TabStop = true;
            this.rdbtnPartOutsourced.Text = "Outsourced";
            this.rdbtnPartOutsourced.UseVisualStyleBackColor = true;
            this.rdbtnPartOutsourced.CheckedChanged += new System.EventHandler(this.rdbtnPartOutsourced_CheckedChanged);
            // 
            // AddPartIDLabel
            // 
            this.AddPartIDLabel.AutoSize = true;
            this.AddPartIDLabel.Location = new System.Drawing.Point(49, 102);
            this.AddPartIDLabel.Name = "AddPartIDLabel";
            this.AddPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.AddPartIDLabel.TabIndex = 3;
            this.AddPartIDLabel.Text = "ID";
            // 
            // AddPartNameLabel
            // 
            this.AddPartNameLabel.AutoSize = true;
            this.AddPartNameLabel.Location = new System.Drawing.Point(46, 147);
            this.AddPartNameLabel.Name = "AddPartNameLabel";
            this.AddPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.AddPartNameLabel.TabIndex = 4;
            this.AddPartNameLabel.Text = "Name";
            // 
            // AddPartInventoryLabel
            // 
            this.AddPartInventoryLabel.AutoSize = true;
            this.AddPartInventoryLabel.Location = new System.Drawing.Point(46, 197);
            this.AddPartInventoryLabel.Name = "AddPartInventoryLabel";
            this.AddPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.AddPartInventoryLabel.TabIndex = 5;
            this.AddPartInventoryLabel.Text = "Inventory";
            // 
            // AddPartPriceLabel
            // 
            this.AddPartPriceLabel.AutoSize = true;
            this.AddPartPriceLabel.Location = new System.Drawing.Point(46, 241);
            this.AddPartPriceLabel.Name = "AddPartPriceLabel";
            this.AddPartPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.AddPartPriceLabel.TabIndex = 6;
            this.AddPartPriceLabel.Text = "Price / Cost";
            // 
            // AddPartMaxLabel
            // 
            this.AddPartMaxLabel.AutoSize = true;
            this.AddPartMaxLabel.Location = new System.Drawing.Point(47, 286);
            this.AddPartMaxLabel.Name = "AddPartMaxLabel";
            this.AddPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.AddPartMaxLabel.TabIndex = 7;
            this.AddPartMaxLabel.Text = "Max";
            // 
            // AddPartMinLabel
            // 
            this.AddPartMinLabel.AutoSize = true;
            this.AddPartMinLabel.Location = new System.Drawing.Point(214, 283);
            this.AddPartMinLabel.Name = "AddPartMinLabel";
            this.AddPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.AddPartMinLabel.TabIndex = 8;
            this.AddPartMinLabel.Text = "Min";
            // 
            // AddPartMachineIDLabel
            // 
            this.AddPartMachineIDLabel.AutoSize = true;
            this.AddPartMachineIDLabel.Location = new System.Drawing.Point(47, 328);
            this.AddPartMachineIDLabel.Name = "AddPartMachineIDLabel";
            this.AddPartMachineIDLabel.Size = new System.Drawing.Size(90, 20);
            this.AddPartMachineIDLabel.TabIndex = 9;
            this.AddPartMachineIDLabel.Text = "Machine ID";
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Location = new System.Drawing.Point(79, 393);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(93, 26);
            this.btnAddPartSave.TabIndex = 10;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.btnAddPartSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textIDAddPart
            // 
            this.textIDAddPart.Location = new System.Drawing.Point(162, 99);
            this.textIDAddPart.Name = "textIDAddPart";
            this.textIDAddPart.Size = new System.Drawing.Size(202, 26);
            this.textIDAddPart.TabIndex = 12;
            // 
            // textNameAddPart
            // 
            this.textNameAddPart.Location = new System.Drawing.Point(162, 141);
            this.textNameAddPart.Name = "textNameAddPart";
            this.textNameAddPart.Size = new System.Drawing.Size(204, 26);
            this.textNameAddPart.TabIndex = 13;
            // 
            // textInventoryAddPart
            // 
            this.textInventoryAddPart.Location = new System.Drawing.Point(162, 191);
            this.textInventoryAddPart.Name = "textInventoryAddPart";
            this.textInventoryAddPart.Size = new System.Drawing.Size(204, 26);
            this.textInventoryAddPart.TabIndex = 14;
            // 
            // textPriceAddPart
            // 
            this.textPriceAddPart.Location = new System.Drawing.Point(165, 235);
            this.textPriceAddPart.Name = "textPriceAddPart";
            this.textPriceAddPart.Size = new System.Drawing.Size(201, 26);
            this.textPriceAddPart.TabIndex = 15;
            // 
            // textMaxAddPart
            // 
            this.textMaxAddPart.Location = new System.Drawing.Point(105, 283);
            this.textMaxAddPart.Name = "textMaxAddPart";
            this.textMaxAddPart.Size = new System.Drawing.Size(82, 26);
            this.textMaxAddPart.TabIndex = 16;
            // 
            // textMinAddPart
            // 
            this.textMinAddPart.Location = new System.Drawing.Point(283, 283);
            this.textMinAddPart.Name = "textMinAddPart";
            this.textMinAddPart.Size = new System.Drawing.Size(83, 26);
            this.textMinAddPart.TabIndex = 17;
            // 
            // textMachineIDAddPart
            // 
            this.textMachineIDAddPart.Location = new System.Drawing.Point(180, 322);
            this.textMachineIDAddPart.Name = "textMachineIDAddPart";
            this.textMachineIDAddPart.Size = new System.Drawing.Size(186, 26);
            this.textMachineIDAddPart.TabIndex = 18;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.textMachineIDAddPart);
            this.Controls.Add(this.textMinAddPart);
            this.Controls.Add(this.textMaxAddPart);
            this.Controls.Add(this.textPriceAddPart);
            this.Controls.Add(this.textInventoryAddPart);
            this.Controls.Add(this.textNameAddPart);
            this.Controls.Add(this.textIDAddPart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.AddPartMachineIDLabel);
            this.Controls.Add(this.AddPartMinLabel);
            this.Controls.Add(this.AddPartMaxLabel);
            this.Controls.Add(this.AddPartPriceLabel);
            this.Controls.Add(this.AddPartInventoryLabel);
            this.Controls.Add(this.AddPartNameLabel);
            this.Controls.Add(this.AddPartIDLabel);
            this.Controls.Add(this.rdbtnPartOutsourced);
            this.Controls.Add(this.rdbtnPartInHouse);
            this.Controls.Add(this.addPartLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton rdbtnPartInHouse;
        private System.Windows.Forms.RadioButton rdbtnPartOutsourced;
        private System.Windows.Forms.Label AddPartIDLabel;
        private System.Windows.Forms.Label AddPartNameLabel;
        private System.Windows.Forms.Label AddPartInventoryLabel;
        private System.Windows.Forms.Label AddPartPriceLabel;
        private System.Windows.Forms.Label AddPartMaxLabel;
        private System.Windows.Forms.Label AddPartMinLabel;
        private System.Windows.Forms.Label AddPartMachineIDLabel;
        private System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textIDAddPart;
        private System.Windows.Forms.TextBox textNameAddPart;
        private System.Windows.Forms.TextBox textInventoryAddPart;
        private System.Windows.Forms.TextBox textPriceAddPart;
        private System.Windows.Forms.TextBox textMaxAddPart;
        private System.Windows.Forms.TextBox textMinAddPart;
        private System.Windows.Forms.TextBox textMachineIDAddPart;
    }
}