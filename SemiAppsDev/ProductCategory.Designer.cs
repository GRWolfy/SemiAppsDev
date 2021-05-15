
namespace SemiAppsDev
{
   partial class ProductCategory
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
         this.tabControlCategory = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.txtId = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtProductCategory = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tabPageCategory = new System.Windows.Forms.TabPage();
         this.dataGridCategory = new System.Windows.Forms.DataGridView();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.tabControlCategory.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPageCategory.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControlCategory
         // 
         this.tabControlCategory.Controls.Add(this.tabPage1);
         this.tabControlCategory.Controls.Add(this.tabPageCategory);
         this.tabControlCategory.Location = new System.Drawing.Point(205, 44);
         this.tabControlCategory.Name = "tabControlCategory";
         this.tabControlCategory.SelectedIndex = 0;
         this.tabControlCategory.Size = new System.Drawing.Size(551, 352);
         this.tabControlCategory.TabIndex = 1;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.txtId);
         this.tabPage1.Controls.Add(this.label5);
         this.tabPage1.Controls.Add(this.txtProductCategory);
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
         // txtId
         // 
         this.txtId.Location = new System.Drawing.Point(203, 122);
         this.txtId.Name = "txtId";
         this.txtId.Size = new System.Drawing.Size(154, 20);
         this.txtId.TabIndex = 14;
         this.txtId.Visible = false;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(38, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(0, 13);
         this.label5.TabIndex = 13;
         // 
         // txtProductCategory
         // 
         this.txtProductCategory.Location = new System.Drawing.Point(203, 163);
         this.txtProductCategory.Name = "txtProductCategory";
         this.txtProductCategory.Size = new System.Drawing.Size(154, 20);
         this.txtProductCategory.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(115, 170);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(117, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Product category name";
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(292, 269);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(187, 269);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // tabPageCategory
         // 
         this.tabPageCategory.Controls.Add(this.dataGridCategory);
         this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
         this.tabPageCategory.Name = "tabPageCategory";
         this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageCategory.Size = new System.Drawing.Size(543, 326);
         this.tabPageCategory.TabIndex = 1;
         this.tabPageCategory.Text = "View Product";
         this.tabPageCategory.UseVisualStyleBackColor = true;
         // 
         // dataGridCategory
         // 
         this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridCategory.Location = new System.Drawing.Point(0, 47);
         this.dataGridCategory.Name = "dataGridCategory";
         this.dataGridCategory.Size = new System.Drawing.Size(537, 273);
         this.dataGridCategory.TabIndex = 0;
         this.dataGridCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCategory_CellMouseClick);
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
         // ProductCategory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.tabControlCategory);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "ProductCategory";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ProductCategory";
         this.Load += new System.EventHandler(this.ProductCategory_Load);
         this.tabControlCategory.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPageCategory.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControlCategory;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtProductCategory;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TabPage tabPageCategory;
      private System.Windows.Forms.DataGridView dataGridCategory;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.TextBox txtId;
   }
}