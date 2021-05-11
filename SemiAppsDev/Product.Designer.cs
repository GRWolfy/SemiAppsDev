
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
         this.tabControlProduct = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtReorder = new System.Windows.Forms.TextBox();
         this.txtStockonHand = new System.Windows.Forms.TextBox();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.txtProductname = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.dataGridProduct = new System.Windows.Forms.DataGridView();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnRegister = new System.Windows.Forms.Button();
         this.btnProduct = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.cmbCategory = new System.Windows.Forms.ComboBox();
         this.txtCategoryID = new System.Windows.Forms.TextBox();
         this.txtProductID = new System.Windows.Forms.TextBox();
         this.tabControlProduct.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControlProduct
         // 
         this.tabControlProduct.Controls.Add(this.tabPage1);
         this.tabControlProduct.Controls.Add(this.tabPage2);
         this.tabControlProduct.Location = new System.Drawing.Point(181, 65);
         this.tabControlProduct.Name = "tabControlProduct";
         this.tabControlProduct.SelectedIndex = 0;
         this.tabControlProduct.Size = new System.Drawing.Size(551, 352);
         this.tabControlProduct.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.txtProductID);
         this.tabPage1.Controls.Add(this.txtCategoryID);
         this.tabPage1.Controls.Add(this.cmbCategory);
         this.tabPage1.Controls.Add(this.label7);
         this.tabPage1.Controls.Add(this.label6);
         this.tabPage1.Controls.Add(this.label5);
         this.tabPage1.Controls.Add(this.label4);
         this.tabPage1.Controls.Add(this.dateTimePicker);
         this.tabPage1.Controls.Add(this.label3);
         this.tabPage1.Controls.Add(this.label2);
         this.tabPage1.Controls.Add(this.txtReorder);
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
         this.tabPage1.Text = "Add | Update Product";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(46, 250);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(74, 13);
         this.label7.TabIndex = 15;
         this.label7.Text = "Reorder stock";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(18, 32);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(102, 13);
         this.label6.TabIndex = 14;
         this.label6.Text = "Product category ID";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(38, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(0, 13);
         this.label5.TabIndex = 13;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(69, 205);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(30, 13);
         this.label4.TabIndex = 12;
         this.label4.Text = "Date";
         // 
         // dateTimePicker
         // 
         this.dateTimePicker.Location = new System.Drawing.Point(126, 199);
         this.dateTimePicker.Name = "dateTimePicker";
         this.dateTimePicker.Size = new System.Drawing.Size(154, 20);
         this.dateTimePicker.TabIndex = 11;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(34, 159);
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
         // txtReorder
         // 
         this.txtReorder.Location = new System.Drawing.Point(126, 243);
         this.txtReorder.Name = "txtReorder";
         this.txtReorder.Size = new System.Drawing.Size(154, 20);
         this.txtReorder.TabIndex = 8;
         // 
         // txtStockonHand
         // 
         this.txtStockonHand.Location = new System.Drawing.Point(126, 152);
         this.txtStockonHand.Name = "txtStockonHand";
         this.txtStockonHand.Size = new System.Drawing.Size(154, 20);
         this.txtStockonHand.TabIndex = 6;
         // 
         // txtPrice
         // 
         this.txtPrice.Location = new System.Drawing.Point(126, 107);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(154, 20);
         this.txtPrice.TabIndex = 5;
         // 
         // txtProductname
         // 
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
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(292, 278);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(187, 278);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.dataGridProduct);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(543, 326);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "View Product";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // dataGridProduct
         // 
         this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridProduct.Location = new System.Drawing.Point(3, 47);
         this.dataGridProduct.Name = "dataGridProduct";
         this.dataGridProduct.Size = new System.Drawing.Size(537, 273);
         this.dataGridProduct.TabIndex = 0;
         this.dataGridProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProduct_CellMouseClick);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.btnLogin);
         this.panel1.Controls.Add(this.btnRegister);
         this.panel1.Controls.Add(this.btnProduct);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Location = new System.Drawing.Point(8, 15);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 402);
         this.panel1.TabIndex = 4;
         // 
         // btnInventory
         // 
         this.btnInventory.Location = new System.Drawing.Point(22, 337);
         this.btnInventory.Name = "btnInventory";
         this.btnInventory.Size = new System.Drawing.Size(117, 36);
         this.btnInventory.TabIndex = 5;
         this.btnInventory.Text = "Inventory Details";
         this.btnInventory.UseVisualStyleBackColor = true;
         this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
         // 
         // btnCategory
         // 
         this.btnCategory.Location = new System.Drawing.Point(22, 253);
         this.btnCategory.Name = "btnCategory";
         this.btnCategory.Size = new System.Drawing.Size(117, 36);
         this.btnCategory.TabIndex = 4;
         this.btnCategory.Text = "Product Category";
         this.btnCategory.UseVisualStyleBackColor = true;
         this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(22, 211);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(117, 36);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnRegister
         // 
         this.btnRegister.Location = new System.Drawing.Point(22, 165);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(117, 36);
         this.btnRegister.TabIndex = 2;
         this.btnRegister.Text = "Register";
         this.btnRegister.UseVisualStyleBackColor = true;
         this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
         // 
         // btnProduct
         // 
         this.btnProduct.Location = new System.Drawing.Point(22, 295);
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
         // cmbCategory
         // 
         this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbCategory.FormattingEnabled = true;
         this.cmbCategory.Location = new System.Drawing.Point(126, 29);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.Size = new System.Drawing.Size(154, 21);
         this.cmbCategory.TabIndex = 16;
         this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
         // 
         // txtCategoryID
         // 
         this.txtCategoryID.Location = new System.Drawing.Point(326, 30);
         this.txtCategoryID.Name = "txtCategoryID";
         this.txtCategoryID.Size = new System.Drawing.Size(154, 20);
         this.txtCategoryID.TabIndex = 17;
         this.txtCategoryID.Visible = false;
         // 
         // txtProductID
         // 
         this.txtProductID.Location = new System.Drawing.Point(326, 60);
         this.txtProductID.Name = "txtProductID";
         this.txtProductID.Size = new System.Drawing.Size(154, 20);
         this.txtProductID.TabIndex = 18;
         this.txtProductID.Visible = false;
         // 
         // Product
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.tabControlProduct);
         this.Name = "Product";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Product";
         this.Load += new System.EventHandler(this.Product_Load);
         this.tabControlProduct.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControlProduct;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtReorder;
      private System.Windows.Forms.TextBox txtStockonHand;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.TextBox txtProductname;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.DataGridView dataGridProduct;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.DateTimePicker dateTimePicker;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.Button btnProduct;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.ComboBox cmbCategory;
      private System.Windows.Forms.TextBox txtCategoryID;
      private System.Windows.Forms.TextBox txtProductID;
   }
}