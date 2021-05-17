
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
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.label9 = new System.Windows.Forms.Label();
         this.txtSearch = new System.Windows.Forms.TextBox();
         this.dataGridInventory = new System.Windows.Forms.DataGridView();
         this.panel1.SuspendLayout();
         this.tabControlInvetory.SuspendLayout();
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
         this.tabControlInvetory.Controls.Add(this.tabPage3);
         this.tabControlInvetory.Location = new System.Drawing.Point(214, 45);
         this.tabControlInvetory.Name = "tabControlInvetory";
         this.tabControlInvetory.SelectedIndex = 0;
         this.tabControlInvetory.Size = new System.Drawing.Size(551, 352);
         this.tabControlInvetory.TabIndex = 5;
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.label9);
         this.tabPage3.Controls.Add(this.txtSearch);
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
         // txtSearch
         // 
         this.txtSearch.Location = new System.Drawing.Point(242, 7);
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Size = new System.Drawing.Size(100, 20);
         this.txtSearch.TabIndex = 17;
         this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtSearch;
      private System.Windows.Forms.DataGridView dataGridInventory;
   }
}