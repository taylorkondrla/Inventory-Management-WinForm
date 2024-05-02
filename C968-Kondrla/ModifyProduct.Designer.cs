namespace C968_Kondrla
{
    partial class ModifyProduct
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
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.btnSearchModifyProduct = new System.Windows.Forms.Button();
            this.textSearchModifyProduct = new System.Windows.Forms.TextBox();
            this.candidatePartsModifyLabel = new System.Windows.Forms.Label();
            this.candidateModifyGridView = new System.Windows.Forms.DataGridView();
            this.associatedModifyLabel = new System.Windows.Forms.Label();
            this.associatedModifyGridView = new System.Windows.Forms.DataGridView();
            this.btnCandidateAddModify = new System.Windows.Forms.Button();
            this.btnSaveModify = new System.Windows.Forms.Button();
            this.btnCancelModify = new System.Windows.Forms.Button();
            this.btnDeleteModify = new System.Windows.Forms.Button();
            this.modifyIDLabel = new System.Windows.Forms.Label();
            this.modifyNameLabel = new System.Windows.Forms.Label();
            this.modifyInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPriceLabel = new System.Windows.Forms.Label();
            this.modifyMaxLabel = new System.Windows.Forms.Label();
            this.modifyMinLabel = new System.Windows.Forms.Label();
            this.textIDModify = new System.Windows.Forms.TextBox();
            this.textNameModify = new System.Windows.Forms.TextBox();
            this.textInventoryModify = new System.Windows.Forms.TextBox();
            this.textPriceModify = new System.Windows.Forms.TextBox();
            this.textMaxModify = new System.Windows.Forms.TextBox();
            this.textMinModify = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidateModifyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedModifyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(18, 21);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(96, 16);
            this.ModifyProductLabel.TabIndex = 0;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // btnSearchModifyProduct
            // 
            this.btnSearchModifyProduct.Location = new System.Drawing.Point(483, 20);
            this.btnSearchModifyProduct.Name = "btnSearchModifyProduct";
            this.btnSearchModifyProduct.Size = new System.Drawing.Size(98, 26);
            this.btnSearchModifyProduct.TabIndex = 1;
            this.btnSearchModifyProduct.Text = "Search";
            this.btnSearchModifyProduct.UseVisualStyleBackColor = true;
            this.btnSearchModifyProduct.Click += new System.EventHandler(this.btnSearchModifyProduct_Click);
            // 
            // textSearchModifyProduct
            // 
            this.textSearchModifyProduct.Location = new System.Drawing.Point(602, 23);
            this.textSearchModifyProduct.Name = "textSearchModifyProduct";
            this.textSearchModifyProduct.Size = new System.Drawing.Size(169, 20);
            this.textSearchModifyProduct.TabIndex = 2;
            // 
            // candidatePartsModifyLabel
            // 
            this.candidatePartsModifyLabel.AutoSize = true;
            this.candidatePartsModifyLabel.Location = new System.Drawing.Point(322, 57);
            this.candidatePartsModifyLabel.Name = "candidatePartsModifyLabel";
            this.candidatePartsModifyLabel.Size = new System.Drawing.Size(96, 13);
            this.candidatePartsModifyLabel.TabIndex = 3;
            this.candidatePartsModifyLabel.Text = "All Candidate Parts";
            // 
            // candidateModifyGridView
            // 
            this.candidateModifyGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.candidateModifyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateModifyGridView.Location = new System.Drawing.Point(325, 73);
            this.candidateModifyGridView.Name = "candidateModifyGridView";
            this.candidateModifyGridView.Size = new System.Drawing.Size(463, 201);
            this.candidateModifyGridView.TabIndex = 4;
            // 
            // associatedModifyLabel
            // 
            this.associatedModifyLabel.AutoSize = true;
            this.associatedModifyLabel.Location = new System.Drawing.Point(325, 301);
            this.associatedModifyLabel.Name = "associatedModifyLabel";
            this.associatedModifyLabel.Size = new System.Drawing.Size(174, 13);
            this.associatedModifyLabel.TabIndex = 5;
            this.associatedModifyLabel.Text = "Parts Associated With This Product";
            // 
            // associatedModifyGridView
            // 
            this.associatedModifyGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.associatedModifyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedModifyGridView.Location = new System.Drawing.Point(329, 317);
            this.associatedModifyGridView.Name = "associatedModifyGridView";
            this.associatedModifyGridView.Size = new System.Drawing.Size(459, 176);
            this.associatedModifyGridView.TabIndex = 6;
            // 
            // btnCandidateAddModify
            // 
            this.btnCandidateAddModify.Location = new System.Drawing.Point(719, 280);
            this.btnCandidateAddModify.Name = "btnCandidateAddModify";
            this.btnCandidateAddModify.Size = new System.Drawing.Size(68, 24);
            this.btnCandidateAddModify.TabIndex = 7;
            this.btnCandidateAddModify.Text = "Add";
            this.btnCandidateAddModify.UseVisualStyleBackColor = true;
            this.btnCandidateAddModify.Click += new System.EventHandler(this.btnCandidateAddModify_Click);
            // 
            // btnSaveModify
            // 
            this.btnSaveModify.Location = new System.Drawing.Point(503, 510);
            this.btnSaveModify.Name = "btnSaveModify";
            this.btnSaveModify.Size = new System.Drawing.Size(78, 23);
            this.btnSaveModify.TabIndex = 8;
            this.btnSaveModify.Text = "Save";
            this.btnSaveModify.UseVisualStyleBackColor = true;
            this.btnSaveModify.Click += new System.EventHandler(this.btnSaveModify_Click);
            // 
            // btnCancelModify
            // 
            this.btnCancelModify.Location = new System.Drawing.Point(602, 509);
            this.btnCancelModify.Name = "btnCancelModify";
            this.btnCancelModify.Size = new System.Drawing.Size(85, 23);
            this.btnCancelModify.TabIndex = 9;
            this.btnCancelModify.Text = "Cancel";
            this.btnCancelModify.UseVisualStyleBackColor = true;
            this.btnCancelModify.Click += new System.EventHandler(this.btnCancelModify_Click);
            // 
            // btnDeleteModify
            // 
            this.btnDeleteModify.Location = new System.Drawing.Point(711, 509);
            this.btnDeleteModify.Name = "btnDeleteModify";
            this.btnDeleteModify.Size = new System.Drawing.Size(76, 23);
            this.btnDeleteModify.TabIndex = 10;
            this.btnDeleteModify.Text = "Delete";
            this.btnDeleteModify.UseVisualStyleBackColor = true;
            this.btnDeleteModify.Click += new System.EventHandler(this.btnDeleteModify_Click);
            // 
            // modifyIDLabel
            // 
            this.modifyIDLabel.AutoSize = true;
            this.modifyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyIDLabel.Location = new System.Drawing.Point(8, 81);
            this.modifyIDLabel.Name = "modifyIDLabel";
            this.modifyIDLabel.Size = new System.Drawing.Size(26, 20);
            this.modifyIDLabel.TabIndex = 11;
            this.modifyIDLabel.Text = "ID";
            // 
            // modifyNameLabel
            // 
            this.modifyNameLabel.AutoSize = true;
            this.modifyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyNameLabel.Location = new System.Drawing.Point(8, 124);
            this.modifyNameLabel.Name = "modifyNameLabel";
            this.modifyNameLabel.Size = new System.Drawing.Size(51, 20);
            this.modifyNameLabel.TabIndex = 12;
            this.modifyNameLabel.Text = "Name";
            // 
            // modifyInventoryLabel
            // 
            this.modifyInventoryLabel.AutoSize = true;
            this.modifyInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyInventoryLabel.Location = new System.Drawing.Point(8, 165);
            this.modifyInventoryLabel.Name = "modifyInventoryLabel";
            this.modifyInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.modifyInventoryLabel.TabIndex = 13;
            this.modifyInventoryLabel.Text = "Inventory";
            // 
            // modifyPriceLabel
            // 
            this.modifyPriceLabel.AutoSize = true;
            this.modifyPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPriceLabel.Location = new System.Drawing.Point(8, 215);
            this.modifyPriceLabel.Name = "modifyPriceLabel";
            this.modifyPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.modifyPriceLabel.TabIndex = 14;
            this.modifyPriceLabel.Text = "Price";
            // 
            // modifyMaxLabel
            // 
            this.modifyMaxLabel.AutoSize = true;
            this.modifyMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyMaxLabel.Location = new System.Drawing.Point(8, 270);
            this.modifyMaxLabel.Name = "modifyMaxLabel";
            this.modifyMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.modifyMaxLabel.TabIndex = 15;
            this.modifyMaxLabel.Text = "Max";
            // 
            // modifyMinLabel
            // 
            this.modifyMinLabel.AutoSize = true;
            this.modifyMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyMinLabel.Location = new System.Drawing.Point(138, 270);
            this.modifyMinLabel.Name = "modifyMinLabel";
            this.modifyMinLabel.Size = new System.Drawing.Size(34, 20);
            this.modifyMinLabel.TabIndex = 16;
            this.modifyMinLabel.Text = "Min";
            // 
            // textIDModify
            // 
            this.textIDModify.Location = new System.Drawing.Point(71, 83);
            this.textIDModify.Name = "textIDModify";
            this.textIDModify.Size = new System.Drawing.Size(171, 20);
            this.textIDModify.TabIndex = 17;
            // 
            // textNameModify
            // 
            this.textNameModify.Location = new System.Drawing.Point(71, 126);
            this.textNameModify.Name = "textNameModify";
            this.textNameModify.Size = new System.Drawing.Size(171, 20);
            this.textNameModify.TabIndex = 18;
            // 
            // textInventoryModify
            // 
            this.textInventoryModify.Location = new System.Drawing.Point(99, 165);
            this.textInventoryModify.Name = "textInventoryModify";
            this.textInventoryModify.Size = new System.Drawing.Size(143, 20);
            this.textInventoryModify.TabIndex = 19;
            // 
            // textPriceModify
            // 
            this.textPriceModify.Location = new System.Drawing.Point(81, 215);
            this.textPriceModify.Name = "textPriceModify";
            this.textPriceModify.Size = new System.Drawing.Size(161, 20);
            this.textPriceModify.TabIndex = 20;
            // 
            // textMaxModify
            // 
            this.textMaxModify.Location = new System.Drawing.Point(59, 267);
            this.textMaxModify.Name = "textMaxModify";
            this.textMaxModify.Size = new System.Drawing.Size(67, 20);
            this.textMaxModify.TabIndex = 21;
            // 
            // textMinModify
            // 
            this.textMinModify.Location = new System.Drawing.Point(191, 269);
            this.textMinModify.Name = "textMinModify";
            this.textMinModify.Size = new System.Drawing.Size(73, 20);
            this.textMinModify.TabIndex = 22;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(815, 556);
            this.Controls.Add(this.textMinModify);
            this.Controls.Add(this.textMaxModify);
            this.Controls.Add(this.textPriceModify);
            this.Controls.Add(this.textInventoryModify);
            this.Controls.Add(this.textNameModify);
            this.Controls.Add(this.textIDModify);
            this.Controls.Add(this.modifyMinLabel);
            this.Controls.Add(this.modifyMaxLabel);
            this.Controls.Add(this.modifyPriceLabel);
            this.Controls.Add(this.modifyInventoryLabel);
            this.Controls.Add(this.modifyNameLabel);
            this.Controls.Add(this.modifyIDLabel);
            this.Controls.Add(this.btnDeleteModify);
            this.Controls.Add(this.btnCancelModify);
            this.Controls.Add(this.btnSaveModify);
            this.Controls.Add(this.btnCandidateAddModify);
            this.Controls.Add(this.associatedModifyGridView);
            this.Controls.Add(this.associatedModifyLabel);
            this.Controls.Add(this.candidateModifyGridView);
            this.Controls.Add(this.candidatePartsModifyLabel);
            this.Controls.Add(this.textSearchModifyProduct);
            this.Controls.Add(this.btnSearchModifyProduct);
            this.Controls.Add(this.ModifyProductLabel);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.candidateModifyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedModifyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Button btnSearchModifyProduct;
        private System.Windows.Forms.TextBox textSearchModifyProduct;
        private System.Windows.Forms.Label candidatePartsModifyLabel;
        private System.Windows.Forms.DataGridView candidateModifyGridView;
        private System.Windows.Forms.Label associatedModifyLabel;
        private System.Windows.Forms.DataGridView associatedModifyGridView;
        private System.Windows.Forms.Button btnCandidateAddModify;
        private System.Windows.Forms.Button btnSaveModify;
        private System.Windows.Forms.Button btnCancelModify;
        private System.Windows.Forms.Button btnDeleteModify;
        private System.Windows.Forms.Label modifyIDLabel;
        private System.Windows.Forms.Label modifyNameLabel;
        private System.Windows.Forms.Label modifyInventoryLabel;
        private System.Windows.Forms.Label modifyPriceLabel;
        private System.Windows.Forms.Label modifyMaxLabel;
        private System.Windows.Forms.Label modifyMinLabel;
        private System.Windows.Forms.TextBox textIDModify;
        private System.Windows.Forms.TextBox textNameModify;
        private System.Windows.Forms.TextBox textInventoryModify;
        private System.Windows.Forms.TextBox textPriceModify;
        private System.Windows.Forms.TextBox textMaxModify;
        private System.Windows.Forms.TextBox textMinModify;
    }
}