
namespace SemiAppsDev
{
   partial class InventoryDetails
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.tabControlInvetory = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.btnReorder = new System.Windows.Forms.Button();
         this.txtInvetoryID = new System.Windows.Forms.TextBox();
         this.btnDelete = new System.Windows.Forms.Button();
         this.txtProductID = new System.Windows.Forms.TextBox();
         this.txtCategoryID = new System.Windows.Forms.TextBox();
         this.cmbCategory = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtStockout = new System.Windows.Forms.TextBox();
         this.txtStockonHand = new System.Windows.Forms.TextBox();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.txtProductname = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.label8 = new System.Windows.Forms.Label();
         this.txtSearch = new System.Windows.Forms.TextBox();
         this.dataGridProduct = new System.Windows.Forms.DataGridView();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.label9 = new System.Windows.Forms.Label();
         this.txtSearch2 = new System.Windows.Forms.TextBox();
         this.dataGridInventory = new System.Windows.Forms.DataGridView();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.tabControlInvetory.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
         this.tabPage3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.Product);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Location = new System.Drawing.Point(13, 13);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 402);
         this.panel1.TabIndex = 4;
         // 
         // btnInventory
         // 
         this.btnInventory.Location = new System.Drawing.Point(22, 249);
         this.btnInventory.Name = "btnInventory";
         this.btnInventory.Size = new System.Drawing.Size(117, 36);
         this.btnInventory.TabIndex = 5;
         this.btnInventory.Text = "Inventory Details";
         this.btnInventory.UseVisualStyleBackColor = true;
         this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
         // 
         // btnCategory
         // 
         this.btnCategory.Location = new System.Drawing.Point(22, 165);
         this.btnCategory.Name = "btnCategory";
         this.btnCategory.Size = new System.Drawing.Size(117, 36);
         this.btnCategory.TabIndex = 4;
         this.btnCategory.Text = "Product Category";
         this.btnCategory.UseVisualStyleBackColor = true;
         this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
         // 
         // Product
         // 
         this.Product.Location = new System.Drawing.Point(22, 207);
         this.Product.Name = "Product";
         this.Product.Size = new System.Drawing.Size(117, 36);
         this.Product.TabIndex = 1;
         this.Product.Text = "Product";
         this.Product.UseVisualStyleBackColor = true;
         this.Product.Click += new System.EventHandler(this.Product_Click);
         // 
         // btnDashboard
         // 
         this.btnDashboard.Location = new System.Drawing.Point(22, 123);
         this.btnDashboard.Name = "btnDashboard";
         this.btnDashboard.Size = new System.Drawing.Size(117, 36);
         this.btnDashboard.TabIndex = 0;
         this.btnDashboard.Text = "Dashboard";
         this.btnDashboard.UseVisualStyleBackColor = true;
         this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
         // 
         // tabControlInvetory
         // 
         this.tabControlInvetory.Controls.Add(this.tabPage1);
         this.tabControlInvetory.Controls.Add(this.tabPage2);
         this.tabControlInvetory.Controls.Add(this.tabPage3);
         this.tabControlInvetory.Location = new System.Drawing.Point(214, 45);
         this.tabControlInvetory.Name = "tabControlInvetory";
         this.tabControlInvetory.SelectedIndex = 0;
         this.tabControlInvetory.Size = new System.Drawing.Size(551, 352);
         this.tabControlInvetory.TabIndex = 5;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.btnReorder);
         this.tabPage1.Controls.Add(this.txtInvetoryID);
         this.tabPage1.Controls.Add(this.btnDelete);
         this.tabPage1.Controls.Add(this.txtProductID);
         this.tabPage1.Controls.Add(this.txtCategoryID);
         this.tabPage1.Controls.Add(this.cmbCategory);
         this.tabPage1.Controls.Add(this.label7);
         this.tabPage1.Controls.Add(this.label6);
         this.tabPage1.Controls.Add(this.label5);
         this.tabPage1.Controls.Add(this.label3);
         this.tabPage1.Controls.Add(this.label2);
         this.tabPage1.Controls.Add(this.txtStockout);
         this.tabPage1.Controls.Add(this.txtStockonHand);
         this.tabPage1.Controls.Add(this.txtPrice);
         this.tabPage1.Controls.Add(this.txtProductname);
         this.tabPage1.Controls.Add(this.label1);
         this.tabPage1.Controls.Add(this.btnUpdate);
         this.tabPage1.Controls.Add(this.btnSave);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(543, 326);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Add | Update Inventory";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // btnReorder
         // 
         this.btnReorder.Location = new System.Drawing.Point(405, 282);
         this.btnReorder.Name = "btnReorder";
         this.btnReorder.Size = new System.Drawing.Size(75, 23);
         this.btnReorder.TabIndex = 21;
         this.btnReorder.Text = "Reorder";
         this.btnReorder.UseVisualStyleBackColor = true;
         this.btnReorder.Visible = false;
         this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
         // 
         // txtInvetoryID
         // 
         this.txtInvetoryID.Location = new System.Drawing.Point(326, 86);
         this.txtInvetoryID.Name = "txtInvetoryID";
         this.txtInvetoryID.Size = new System.Drawing.Size(154, 20);
         this.txtInvetoryID.TabIndex = 20;
         this.txtInvetoryID.Visible = false;
         // 
         // btnDelete
         // 
         this.btnDelete.Enabled = false;
         this.btnDelete.Location = new System.Drawing.Point(306, 282);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 19;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // txtProductID
         // 
         this.txtProductID.Location = new System.Drawing.Point(326, 60);
         this.txtProductID.Name = "txtProductID";
         this.txtProductID.Size = new System.Drawing.Size(154, 20);
         this.txtProductID.TabIndex = 18;
         this.txtProductID.Visible = false;
         // 
         // txtCategoryID
         // 
         this.txtCategoryID.Location = new System.Drawing.Point(326, 30);
         this.txtCategoryID.Name = "txtCategoryID";
         this.txtCategoryID.Size = new System.Drawing.Size(154, 20);
         this.txtCategoryID.TabIndex = 17;
         this.txtCategoryID.Visible = false;
         // 
         // cmbCategory
         // 
         this.cmbCategory.Enabled = false;
         this.cmbCategory.FormattingEnabled = true;
         this.cmbCategory.Location = new System.Drawing.Point(126, 29);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.Size = new System.Drawing.Size(154, 21);
         this.cmbCategory.TabIndex = 16;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(46, 202);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(53, 13);
         this.label7.TabIndex = 15;
         this.label7.Text = "Stock out";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(33, 32);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(78, 13);
         this.label6.TabIndex = 14;
         this.label6.Text = "Category name";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(38, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(0, 13);
         this.label5.TabIndex = 13;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(34, 160);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(77, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Stock on hand";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(69, 114);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(31, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "Price";
         // 
         // txtStockout
         // 
         this.txtStockout.Location = new System.Drawing.Point(126, 195);
         this.txtStockout.Name = "txtStockout";
         this.txtStockout.Size = new System.Drawing.Size(154, 20);
         this.txtStockout.TabIndex = 8;
         // 
         // txtStockonHand
         // 
         this.txtStockonHand.Enabled = false;
         this.txtStockonHand.Location = new System.Drawing.Point(126, 153);
         this.txtStockonHand.Name = "txtStockonHand";
         this.txtStockonHand.Size = new System.Drawing.Size(154, 20);
         this.txtStockonHand.TabIndex = 6;
         // 
         // txtPrice
         // 
         this.txtPrice.Enabled = false;
         this.txtPrice.Location = new System.Drawing.Point(126, 107);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(154, 20);
         this.txtPrice.TabIndex = 5;
         // 
         // txtProductname
         // 
         this.txtProductname.Enabled = false;
         this.txtProductname.Location = new System.Drawing.Point(126, 65);
         this.txtProductname.Name = "txtProductname";
         this.txtProductname.Size = new System.Drawing.Size(154, 20);
         this.txtProductname.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(38, 72);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(73, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Product name";
         // 
         // btnSave
         // 
         this.btnSave.Enabled = false;
         this.btnSave.Location = new System.Drawing.Point(104, 282);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.label8);
         this.tabPage2.Controls.Add(this.txtSearch);
         this.tabPage2.Controls.Add(this.dataGridProduct);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(543, 326);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "View Product";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(186, 10);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(41, 13);
         this.label8.TabIndex = 15;
         this.label8.Text = "Search";
         // 
         // txtSearch
         // 
         this.txtSearch.Location = new System.Drawing.Point(242, 7);
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Size = new System.Drawing.Size(100, 20);
         this.txtSearch.TabIndex = 1;
         this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
         // 
         // dataGridProduct
         // 
         this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridProduct.Location = new System.Drawing.Point(3, 38);
         this.dataGridProduct.Name = "dataGridProduct";
         this.dataGridProduct.Size = new System.Drawing.Size(537, 282);
         this.dataGridProduct.TabIndex = 0;
         this.dataGridProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridProduct_CellMouseClick);
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.label9);
         this.tabPage3.Controls.Add(this.txtSearch2);
         this.tabPage3.Controls.Add(this.dataGridInventory);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(543, 326);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "View Inventory Details";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(186, 10);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(41, 13);
         this.label9.TabIndex = 18;
         this.label9.Text = "Search";
         // 
         // txtSearch2
         // 
         this.txtSearch2.Location = new System.Drawing.Point(242, 7);
         this.txtSearch2.Name = "txtSearch2";
         this.txtSearch2.Size = new System.Drawing.Size(100, 20);
         this.txtSearch2.TabIndex = 17;
         this.txtSearch2.TextChanged += new System.EventHandler(this.txtSearch2_TextChanged);
         // 
         // dataGridInventory
         // 
         this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridInventory.Location = new System.Drawing.Point(3, 38);
         this.dataGridInventory.Name = "dataGridInventory";
         this.dataGridInventory.Size = new System.Drawing.Size(537, 282);
         this.dataGridInventory.TabIndex = 16;
         this.dataGridInventory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridInventory_CellMouseClick);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Enabled = false;
         this.btnUpdate.Location = new System.Drawing.Point(209, 282);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // InventoryDetails
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tabControlInvetory);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "InventoryDetails";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "InventoryDetails";
         this.Load += new System.EventHandler(this.InventoryDetails_Load);
         this.panel1.ResumeLayout(false);
         this.tabControlInvetory.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
         this.tabPage3.ResumeLayout(false);
         this.tabPage3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.TabControl tabControlInvetory;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TextBox txtProductID;
      private System.Windows.Forms.TextBox txtCategoryID;
      private System.Windows.Forms.ComboBox cmbCategory;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtStockonHand;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.TextBox txtProductname;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.TextBox txtSearch;
      private System.Windows.Forms.DataGridView dataGridProduct;
      private System.Windows.Forms.TextBox txtStockout;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox txtInvetoryID;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtSearch2;
      private System.Windows.Forms.DataGridView dataGridInventory;
      private System.Windows.Forms.Button btnReorder;
      private System.Windows.Forms.Button btnUpdate;
   }
}