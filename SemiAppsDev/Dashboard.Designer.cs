
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
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(571, 158);
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
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(214, 178);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 4;
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lblTotal);
         this.Name = "Dashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Dashboard";
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button btnLogin;
   }
}