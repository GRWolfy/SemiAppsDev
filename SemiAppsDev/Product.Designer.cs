
namespace SemiAppsDev
{
   partial class Product
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
         this.btnProduct = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.label4 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.cmbCategory = new System.Windows.Forms.ComboBox();
         this.txtProductname = new System.Windows.Forms.TextBox();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.txtStockonHand = new System.Windows.Forms.TextBox();
         this.txtCategoryID = new System.Windows.Forms.TextBox();
         this.txtProductID = new System.Windows.Forms.TextBox();
         this.txtInventoryId = new System.Windows.Forms.TextBox();
         this.txtEncoder = new System.Windows.Forms.TextBox();
         this.txtStockOut = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.btnDelete = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.btnProduct);
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
         // btnProduct
         // 
         this.btnProduct.Location = new System.Drawing.Point(22, 207);
         this.btnProduct.Name = "btnProduct";
         this.btnProduct.Size = new System.Drawing.Size(117, 36);
         this.btnProduct.TabIndex = 1;
         this.btnProduct.Text = "Product";
         this.btnProduct.UseVisualStyleBackColor = true;
         this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
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
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(517, 323);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(622, 323);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(232, 157);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(73, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Product name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(263, 199);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(31, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "Price";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(228, 285);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(77, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Stock on hand";
         // 
         // dateTimePicker
         // 
         this.dateTimePicker.Location = new System.Drawing.Point(320, 236);
         this.dateTimePicker.Name = "dateTimePicker";
         this.dateTimePicker.Size = new System.Drawing.Size(154, 20);
         this.dateTimePicker.TabIndex = 11;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(263, 242);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(30, 13);
         this.label4.TabIndex = 12;
         this.label4.Text = "Date";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(188, 118);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(117, 13);
         this.label6.TabIndex = 14;
         this.label6.Text = "Product category name";
         // 
         // cmbCategory
         // 
         this.cmbCategory.FormattingEnabled = true;
         this.cmbCategory.Location = new System.Drawing.Point(320, 114);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.Size = new System.Drawing.Size(154, 21);
         this.cmbCategory.TabIndex = 16;
         this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
         // 
         // txtProductname
         // 
         this.txtProductname.Location = new System.Drawing.Point(320, 150);
         this.txtProductname.Name = "txtProductname";
         this.txtProductname.Size = new System.Drawing.Size(154, 20);
         this.txtProductname.TabIndex = 4;
         // 
         // txtPrice
         // 
         this.txtPrice.Location = new System.Drawing.Point(320, 192);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(154, 20);
         this.txtPrice.TabIndex = 5;
         // 
         // txtStockonHand
         // 
         this.txtStockonHand.Location = new System.Drawing.Point(320, 278);
         this.txtStockonHand.Name = "txtStockonHand";
         this.txtStockonHand.Size = new System.Drawing.Size(154, 20);
         this.txtStockonHand.TabIndex = 6;
         // 
         // txtCategoryID
         // 
         this.txtCategoryID.Location = new System.Drawing.Point(520, 115);
         this.txtCategoryID.Name = "txtCategoryID";
         this.txtCategoryID.Size = new System.Drawing.Size(154, 20);
         this.txtCategoryID.TabIndex = 17;
         this.txtCategoryID.Visible = false;
         // 
         // txtProductID
         // 
         this.txtProductID.Location = new System.Drawing.Point(520, 145);
         this.txtProductID.Name = "txtProductID";
         this.txtProductID.Size = new System.Drawing.Size(154, 20);
         this.txtProductID.TabIndex = 18;
         this.txtProductID.Visible = false;
         // 
         // txtInventoryId
         // 
         this.txtInventoryId.Location = new System.Drawing.Point(520, 178);
         this.txtInventoryId.Name = "txtInventoryId";
         this.txtInventoryId.Size = new System.Drawing.Size(154, 20);
         this.txtInventoryId.TabIndex = 19;
         this.txtInventoryId.Visible = false;
         // 
         // txtEncoder
         // 
         this.txtEncoder.Location = new System.Drawing.Point(320, 364);
         this.txtEncoder.Name = "txtEncoder";
         this.txtEncoder.Size = new System.Drawing.Size(154, 20);
         this.txtEncoder.TabIndex = 20;
         // 
         // txtStockOut
         // 
         this.txtStockOut.Location = new System.Drawing.Point(320, 323);
         this.txtStockOut.Name = "txtStockOut";
         this.txtStockOut.Size = new System.Drawing.Size(154, 20);
         this.txtStockOut.TabIndex = 21;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(250, 330);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 13);
         this.label5.TabIndex = 22;
         this.label5.Text = "Stock Out";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(258, 371);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(47, 13);
         this.label7.TabIndex = 23;
         this.label7.Text = "Encoder";
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(713, 323);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 24;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         // 
         // Product
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtStockOut);
         this.Controls.Add(this.txtEncoder);
         this.Controls.Add(this.txtInventoryId);
         this.Controls.Add(this.txtProductID);
         this.Controls.Add(this.txtCategoryID);
         this.Controls.Add(this.txtStockonHand);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.txtPrice);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.txtProductname);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.cmbCategory);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.dateTimePicker);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Product";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Product";
         this.Load += new System.EventHandler(this.Product_Load);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button btnProduct;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      public System.Windows.Forms.TextBox txtProductID;
      public System.Windows.Forms.TextBox txtCategoryID;
      public System.Windows.Forms.TextBox txtStockonHand;
      public System.Windows.Forms.TextBox txtPrice;
      public System.Windows.Forms.TextBox txtProductname;
      public System.Windows.Forms.ComboBox cmbCategory;
      public System.Windows.Forms.DateTimePicker dateTimePicker;
      public System.Windows.Forms.Button btnUpdate;
      public System.Windows.Forms.Button btnSave;
      public System.Windows.Forms.TextBox txtInventoryId;
      public System.Windows.Forms.TextBox txtEncoder;
      public System.Windows.Forms.TextBox txtStockOut;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label7;
      public System.Windows.Forms.Button btnDelete;
   }
}