
namespace SemiAppsDev
{
   partial class Login
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
         this.l = new System.Windows.Forms.Label();
         this.btnLoginSave = new System.Windows.Forms.Button();
         this.txtfirstname = new System.Windows.Forms.TextBox();
         this.txtlastname = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.btnRegister = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // l
         // 
         this.l.AutoSize = true;
         this.l.Location = new System.Drawing.Point(297, 133);
         this.l.Name = "l";
         this.l.Size = new System.Drawing.Size(49, 13);
         this.l.TabIndex = 0;
         this.l.Text = "firstname";
         // 
         // btnLoginSave
         // 
         this.btnLoginSave.Location = new System.Drawing.Point(361, 301);
         this.btnLoginSave.Name = "btnLoginSave";
         this.btnLoginSave.Size = new System.Drawing.Size(75, 23);
         this.btnLoginSave.TabIndex = 1;
         this.btnLoginSave.Text = "Login";
         this.btnLoginSave.UseVisualStyleBackColor = true;
         this.btnLoginSave.Click += new System.EventHandler(this.btnLoginSave_Click_1);
         // 
         // txtfirstname
         // 
         this.txtfirstname.Location = new System.Drawing.Point(395, 132);
         this.txtfirstname.Name = "txtfirstname";
         this.txtfirstname.Size = new System.Drawing.Size(100, 20);
         this.txtfirstname.TabIndex = 2;
         // 
         // txtlastname
         // 
         this.txtlastname.Location = new System.Drawing.Point(395, 177);
         this.txtlastname.Name = "txtlastname";
         this.txtlastname.Size = new System.Drawing.Size(100, 20);
         this.txtlastname.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(306, 185);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(49, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "lastname";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.button1);
         this.panel1.Controls.Add(this.btnRegister);
         this.panel1.Controls.Add(this.Product);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Location = new System.Drawing.Point(12, 25);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 402);
         this.panel1.TabIndex = 6;
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
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(22, 211);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(117, 36);
         this.button1.TabIndex = 3;
         this.button1.Text = "Login";
         this.button1.UseVisualStyleBackColor = true;
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
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtlastname);
         this.Controls.Add(this.txtfirstname);
         this.Controls.Add(this.btnLoginSave);
         this.Controls.Add(this.l);
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label l;
      private System.Windows.Forms.Button btnLoginSave;
      private System.Windows.Forms.TextBox txtfirstname;
      private System.Windows.Forms.TextBox txtlastname;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
   }
}