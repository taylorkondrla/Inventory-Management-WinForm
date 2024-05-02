namespace C968_Kondrla
{
    partial class AddProduct
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.candidateDataGrid = new System.Windows.Forms.DataGridView();
            this.candidateLabel = new System.Windows.Forms.Label();
            this.associatedDataGrid = new System.Windows.Forms.DataGridView();
            this.associatedLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.btnCandidateAdd = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.textIDProduct = new System.Windows.Forms.TextBox();
            this.textNameProduct = new System.Windows.Forms.TextBox();
            this.textInventoryProduct = new System.Windows.Forms.TextBox();
            this.textPriceProduct = new System.Windows.Forms.TextBox();
            this.textMaxProduct = new System.Windows.Forms.TextBox();
            this.textMinProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(32, 19);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(97, 20);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(503, 33);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(85, 24);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(605, 33);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // candidateDataGrid
            // 
            this.candidateDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.candidateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateDataGrid.Location = new System.Drawing.Point(297, 69);
            this.candidateDataGrid.Name = "candidateDataGrid";
            this.candidateDataGrid.Size = new System.Drawing.Size(480, 175);
            this.candidateDataGrid.TabIndex = 3;
            // 
            // candidateLabel
            // 
            this.candidateLabel.AutoSize = true;
            this.candidateLabel.Location = new System.Drawing.Point(298, 53);
            this.candidateLabel.Name = "candidateLabel";
            this.candidateLabel.Size = new System.Drawing.Size(96, 13);
            this.candidateLabel.TabIndex = 4;
            this.candidateLabel.Text = "All Candidate Parts";
            // 
            // associatedDataGrid
            // 
            this.associatedDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.associatedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedDataGrid.Location = new System.Drawing.Point(297, 292);
            this.associatedDataGrid.Name = "associatedDataGrid";
            this.associatedDataGrid.Size = new System.Drawing.Size(480, 192);
            this.associatedDataGrid.TabIndex = 5;
            // 
            // associatedLabel
            // 
            this.associatedLabel.AutoSize = true;
            this.associatedLabel.Location = new System.Drawing.Point(298, 276);
            this.associatedLabel.Name = "associatedLabel";
            this.associatedLabel.Size = new System.Drawing.Size(174, 13);
            this.associatedLabel.TabIndex = 6;
            this.associatedLabel.Text = "Parts Associated With This Product";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(17, 89);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(26, 20);
            this.productIDLabel.TabIndex = 7;
            this.productIDLabel.Text = "ID";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(7, 131);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(51, 20);
            this.productNameLabel.TabIndex = 8;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryLabel.Location = new System.Drawing.Point(5, 173);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.productInventoryLabel.TabIndex = 9;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(12, 219);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.productPriceLabel.TabIndex = 10;
            this.productPriceLabel.Text = "Price";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxLabel.Location = new System.Drawing.Point(12, 281);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.productMaxLabel.TabIndex = 11;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinLabel.Location = new System.Drawing.Point(121, 281);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(34, 20);
            this.productMinLabel.TabIndex = 12;
            this.productMinLabel.Text = "Min";
            // 
            // btnCandidateAdd
            // 
            this.btnCandidateAdd.Location = new System.Drawing.Point(696, 252);
            this.btnCandidateAdd.Name = "btnCandidateAdd";
            this.btnCandidateAdd.Size = new System.Drawing.Size(80, 24);
            this.btnCandidateAdd.TabIndex = 13;
            this.btnCandidateAdd.Text = "Add";
            this.btnCandidateAdd.UseVisualStyleBackColor = true;
            this.btnCandidateAdd.Click += new System.EventHandler(this.btnCandidateAdd_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(516, 498);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(72, 25);
            this.btnSaveProduct.TabIndex = 14;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Location = new System.Drawing.Point(605, 498);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(80, 25);
            this.btnCancelProduct.TabIndex = 15;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(700, 497);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // textIDProduct
            // 
            this.textIDProduct.Location = new System.Drawing.Point(81, 89);
            this.textIDProduct.Name = "textIDProduct";
            this.textIDProduct.Size = new System.Drawing.Size(137, 20);
            this.textIDProduct.TabIndex = 17;
            // 
            // textNameProduct
            // 
            this.textNameProduct.Location = new System.Drawing.Point(81, 131);
            this.textNameProduct.Name = "textNameProduct";
            this.textNameProduct.Size = new System.Drawing.Size(136, 20);
            this.textNameProduct.TabIndex = 18;
            // 
            // textInventoryProduct
            // 
            this.textInventoryProduct.Location = new System.Drawing.Point(81, 173);
            this.textInventoryProduct.Name = "textInventoryProduct";
            this.textInventoryProduct.Size = new System.Drawing.Size(136, 20);
            this.textInventoryProduct.TabIndex = 19;
            // 
            // textPriceProduct
            // 
            this.textPriceProduct.Location = new System.Drawing.Point(81, 219);
            this.textPriceProduct.Name = "textPriceProduct";
            this.textPriceProduct.Size = new System.Drawing.Size(137, 20);
            this.textPriceProduct.TabIndex = 20;
            // 
            // textMaxProduct
            // 
            this.textMaxProduct.Location = new System.Drawing.Point(60, 281);
            this.textMaxProduct.Name = "textMaxProduct";
            this.textMaxProduct.Size = new System.Drawing.Size(50, 20);
            this.textMaxProduct.TabIndex = 21;
            // 
            // textMinProduct
            // 
            this.textMinProduct.Location = new System.Drawing.Point(164, 281);
            this.textMinProduct.Name = "textMinProduct";
            this.textMinProduct.Size = new System.Drawing.Size(54, 20);
            this.textMinProduct.TabIndex = 22;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(825, 543);
            this.Controls.Add(this.textMinProduct);
            this.Controls.Add(this.textMaxProduct);
            this.Controls.Add(this.textPriceProduct);
            this.Controls.Add(this.textInventoryProduct);
            this.Controls.Add(this.textNameProduct);
            this.Controls.Add(this.textIDProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnCandidateAdd);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.associatedLabel);
            this.Controls.Add(this.associatedDataGrid);
            this.Controls.Add(this.candidateLabel);
            this.Controls.Add(this.candidateDataGrid);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView candidateDataGrid;
        private System.Windows.Forms.Label candidateLabel;
        private System.Windows.Forms.DataGridView associatedDataGrid;
        private System.Windows.Forms.Label associatedLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Button btnCandidateAdd;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox textIDProduct;
        private System.Windows.Forms.TextBox textNameProduct;
        private System.Windows.Forms.TextBox textInventoryProduct;
        private System.Windows.Forms.TextBox textPriceProduct;
        private System.Windows.Forms.TextBox textMaxProduct;
        private System.Windows.Forms.TextBox textMinProduct;
    }
}