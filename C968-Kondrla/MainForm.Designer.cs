namespace C968_Kondrla
{
    partial class MainForm
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
            this.inventoryManagementSystem = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.searchProductsBtn = new System.Windows.Forms.Button();
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.modifyPartsBtn = new System.Windows.Forms.Button();
            this.DeletePartsBtn = new System.Windows.Forms.Button();
            this.addProductsBtn = new System.Windows.Forms.Button();
            this.modifyProductsBtn = new System.Windows.Forms.Button();
            this.deleteProductsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchParts = new System.Windows.Forms.TextBox();
            this.searchProducts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryManagementSystem
            // 
            this.inventoryManagementSystem.AutoSize = true;
            this.inventoryManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryManagementSystem.Location = new System.Drawing.Point(30, 41);
            this.inventoryManagementSystem.Name = "inventoryManagementSystem";
            this.inventoryManagementSystem.Size = new System.Drawing.Size(256, 20);
            this.inventoryManagementSystem.TabIndex = 0;
            this.inventoryManagementSystem.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(8, 92);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(51, 20);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(444, 92);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(80, 20);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Products";
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.Location = new System.Drawing.Point(211, 89);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 3;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = true;
            this.searchPartsBtn.Click += new System.EventHandler(this.searchPartsBtn_Click);
            // 
            // searchProductsBtn
            // 
            this.searchProductsBtn.Location = new System.Drawing.Point(672, 88);
            this.searchProductsBtn.Name = "searchProductsBtn";
            this.searchProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchProductsBtn.TabIndex = 4;
            this.searchProductsBtn.Text = "Search";
            this.searchProductsBtn.UseVisualStyleBackColor = true;
            this.searchProductsBtn.Click += new System.EventHandler(this.searchProductsBtn_Click);
            // 
            // partsDataGrid
            // 
            this.partsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.partsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGrid.Location = new System.Drawing.Point(12, 123);
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.Size = new System.Drawing.Size(411, 249);
            this.partsDataGrid.TabIndex = 5;
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(448, 123);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.Size = new System.Drawing.Size(428, 249);
            this.productsDataGrid.TabIndex = 6;
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(197, 393);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(68, 24);
            this.addPartBtn.TabIndex = 7;
            this.addPartBtn.Text = "Add";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // modifyPartsBtn
            // 
            this.modifyPartsBtn.Location = new System.Drawing.Point(271, 393);
            this.modifyPartsBtn.Name = "modifyPartsBtn";
            this.modifyPartsBtn.Size = new System.Drawing.Size(73, 24);
            this.modifyPartsBtn.TabIndex = 8;
            this.modifyPartsBtn.Text = "Modify";
            this.modifyPartsBtn.UseVisualStyleBackColor = true;
            this.modifyPartsBtn.Click += new System.EventHandler(this.modifyPartsBtn_Click);
            // 
            // DeletePartsBtn
            // 
            this.DeletePartsBtn.Location = new System.Drawing.Point(351, 393);
            this.DeletePartsBtn.Name = "DeletePartsBtn";
            this.DeletePartsBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletePartsBtn.TabIndex = 9;
            this.DeletePartsBtn.Text = "Delete";
            this.DeletePartsBtn.UseVisualStyleBackColor = true;
            this.DeletePartsBtn.Click += new System.EventHandler(this.DeletePartsBtn_Click);
            // 
            // addProductsBtn
            // 
            this.addProductsBtn.Location = new System.Drawing.Point(636, 393);
            this.addProductsBtn.Name = "addProductsBtn";
            this.addProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductsBtn.TabIndex = 10;
            this.addProductsBtn.Text = "Add";
            this.addProductsBtn.UseVisualStyleBackColor = true;
            this.addProductsBtn.Click += new System.EventHandler(this.addProductsBtn_Click);
            // 
            // modifyProductsBtn
            // 
            this.modifyProductsBtn.Location = new System.Drawing.Point(720, 393);
            this.modifyProductsBtn.Name = "modifyProductsBtn";
            this.modifyProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyProductsBtn.TabIndex = 11;
            this.modifyProductsBtn.Text = "Modify";
            this.modifyProductsBtn.UseVisualStyleBackColor = true;
            this.modifyProductsBtn.Click += new System.EventHandler(this.modifyProductsBtn_Click);
            // 
            // deleteProductsBtn
            // 
            this.deleteProductsBtn.Location = new System.Drawing.Point(801, 393);
            this.deleteProductsBtn.Name = "deleteProductsBtn";
            this.deleteProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteProductsBtn.TabIndex = 12;
            this.deleteProductsBtn.Text = "Delete";
            this.deleteProductsBtn.UseVisualStyleBackColor = true;
            this.deleteProductsBtn.Click += new System.EventHandler(this.deleteProductsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(802, 470);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(292, 90);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(127, 20);
            this.searchParts.TabIndex = 14;
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(755, 92);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(120, 20);
            this.searchProducts.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(888, 496);
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteProductsBtn);
            this.Controls.Add(this.modifyProductsBtn);
            this.Controls.Add(this.addProductsBtn);
            this.Controls.Add(this.DeletePartsBtn);
            this.Controls.Add(this.modifyPartsBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.partsDataGrid);
            this.Controls.Add(this.searchProductsBtn);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.inventoryManagementSystem);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryManagementSystem;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.Button searchProductsBtn;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button modifyPartsBtn;
        private System.Windows.Forms.Button DeletePartsBtn;
        private System.Windows.Forms.Button addProductsBtn;
        private System.Windows.Forms.Button modifyProductsBtn;
        private System.Windows.Forms.Button deleteProductsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox searchParts;
        private System.Windows.Forms.TextBox searchProducts;
        public System.Windows.Forms.DataGridView partsDataGrid;
        public System.Windows.Forms.DataGridView productsDataGrid;
    }
}

