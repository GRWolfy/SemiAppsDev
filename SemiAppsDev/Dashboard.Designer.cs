
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
         this.lblTotal = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnRegister = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.cmbCategory = new System.Windows.Forms.ComboBox();
         this.dataGridCategory = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtCategoryID = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
         this.SuspendLayout();
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(656, 58);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(39, 42);
         this.lblTotal.TabIndex = 1;
         this.lblTotal.Text = "0";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.btnLogin);
         this.panel1.Controls.Add(this.btnRegister);
         this.panel1.Controls.Add(this.Product);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Location = new System.Drawing.Point(13, 13);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 402);
         this.panel1.TabIndex = 3;
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
         // Product
         // 
         this.Product.Location = new System.Drawing.Point(22, 295);
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
         this.cmbCategory.Location = new System.Drawing.Point(186, 145);
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
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(548, 58);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 42);
         this.label1.TabIndex = 6;
         this.label1.Text = "0";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(446, 58);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 42);
         this.label2.TabIndex = 7;
         this.label2.Text = "0";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(314, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(39, 42);
         this.label3.TabIndex = 8;
         this.label3.Text = "0";
         // 
         // txtCategoryID
         // 
         this.txtCategoryID.Location = new System.Drawing.Point(186, 13);
         this.txtCategoryID.Name = "txtCategoryID";
         this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
         this.txtCategoryID.TabIndex = 9;
         this.txtCategoryID.Visible = false;
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.txtCategoryID);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridCategory);
         this.Controls.Add(this.cmbCategory);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lblTotal);
         this.Name = "Dashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Dashboard";
         this.Load += new System.EventHandler(this.Dashboard_Load);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.ComboBox cmbCategory;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.DataGridView dataGridCategory;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtCategoryID;
   }
}