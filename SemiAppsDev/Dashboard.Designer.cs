
namespace SemiAppsDev
{
   partial class Dashboard
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
         this.lblTotalSales = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.cmbCategory = new System.Windows.Forms.ComboBox();
         this.dataGridCategory = new System.Windows.Forms.DataGridView();
         this.lblStockOut = new System.Windows.Forms.Label();
         this.lblStockonHand = new System.Windows.Forms.Label();
         this.lblTotalProduct = new System.Windows.Forms.Label();
         this.txtCategoryID = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblTotalSales
         // 
         this.lblTotalSales.AutoSize = true;
         this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalSales.Location = new System.Drawing.Point(453, 12);
         this.lblTotalSales.Name = "lblTotalSales";
         this.lblTotalSales.Size = new System.Drawing.Size(39, 42);
         this.lblTotalSales.TabIndex = 1;
         this.lblTotalSales.Text = "0";
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
         this.panel1.TabIndex = 3;
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
         // cmbCategory
         // 
         this.cmbCategory.FormattingEnabled = true;
         this.cmbCategory.Location = new System.Drawing.Point(186, 122);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.Size = new System.Drawing.Size(121, 21);
         this.cmbCategory.TabIndex = 4;
         this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
         // 
         // dataGridCategory
         // 
         this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridCategory.Location = new System.Drawing.Point(200, 178);
         this.dataGridCategory.Name = "dataGridCategory";
         this.dataGridCategory.Size = new System.Drawing.Size(567, 252);
         this.dataGridCategory.TabIndex = 5;
         // 
         // lblStockOut
         // 
         this.lblStockOut.AutoSize = true;
         this.lblStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblStockOut.Location = new System.Drawing.Point(344, 12);
         this.lblStockOut.Name = "lblStockOut";
         this.lblStockOut.Size = new System.Drawing.Size(39, 42);
         this.lblStockOut.TabIndex = 6;
         this.lblStockOut.Text = "0";
         // 
         // lblStockonHand
         // 
         this.lblStockonHand.AutoSize = true;
         this.lblStockonHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblStockonHand.Location = new System.Drawing.Point(184, 12);
         this.lblStockonHand.Name = "lblStockonHand";
         this.lblStockonHand.Size = new System.Drawing.Size(39, 42);
         this.lblStockonHand.TabIndex = 7;
         this.lblStockonHand.Text = "0";
         // 
         // lblTotalProduct
         // 
         this.lblTotalProduct.AutoSize = true;
         this.lblTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalProduct.Location = new System.Drawing.Point(58, 12);
         this.lblTotalProduct.Name = "lblTotalProduct";
         this.lblTotalProduct.Size = new System.Drawing.Size(39, 42);
         this.lblTotalProduct.TabIndex = 8;
         this.lblTotalProduct.Text = "0";
         // 
         // txtCategoryID
         // 
         this.txtCategoryID.Location = new System.Drawing.Point(313, 123);
         this.txtCategoryID.Name = "txtCategoryID";
         this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
         this.txtCategoryID.TabIndex = 9;
         this.txtCategoryID.Visible = false;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(22, 71);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(106, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "Overall-Total product";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(159, 71);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(113, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "Overall-Stock on hand";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(319, 71);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(89, 13);
         this.label6.TabIndex = 12;
         this.label6.Text = "Overall-Stock out";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(457, 71);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(96, 13);
         this.label7.TabIndex = 13;
         this.label7.Text = "Overall-Total Sales";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.lblTotalProduct);
         this.panel2.Controls.Add(this.label7);
         this.panel2.Controls.Add(this.lblTotalSales);
         this.panel2.Controls.Add(this.label6);
         this.panel2.Controls.Add(this.lblStockOut);
         this.panel2.Controls.Add(this.label5);
         this.panel2.Controls.Add(this.lblStockonHand);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Location = new System.Drawing.Point(200, 12);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(581, 100);
         this.panel2.TabIndex = 14;
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.txtCategoryID);
         this.Controls.Add(this.dataGridCategory);
         this.Controls.Add(this.cmbCategory);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Dashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Dashboard";
         this.Load += new System.EventHandler(this.Dashboard_Load);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblTotalSales;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.ComboBox cmbCategory;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.DataGridView dataGridCategory;
      private System.Windows.Forms.Label lblStockOut;
      private System.Windows.Forms.Label lblStockonHand;
      private System.Windows.Forms.Label lblTotalProduct;
      private System.Windows.Forms.TextBox txtCategoryID;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Panel panel2;
   }
}