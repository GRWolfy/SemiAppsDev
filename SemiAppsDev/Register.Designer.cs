
namespace SemiAppsDev
{
   partial class Register
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
         this.label2 = new System.Windows.Forms.Label();
         this.txtLastname = new System.Windows.Forms.TextBox();
         this.txtFirstname = new System.Windows.Forms.TextBox();
         this.l = new System.Windows.Forms.Label();
         this.btnRegisterSave = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnInventory = new System.Windows.Forms.Button();
         this.btnCategory = new System.Windows.Forms.Button();
         this.btnLogin = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.Product = new System.Windows.Forms.Button();
         this.btnDashboard = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(310, 245);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Last name";
         // 
         // txtLastname
         // 
         this.txtLastname.Location = new System.Drawing.Point(400, 238);
         this.txtLastname.Name = "txtLastname";
         this.txtLastname.Size = new System.Drawing.Size(100, 20);
         this.txtLastname.TabIndex = 7;
         // 
         // txtFirstname
         // 
         this.txtFirstname.Location = new System.Drawing.Point(400, 193);
         this.txtFirstname.Name = "txtFirstname";
         this.txtFirstname.Size = new System.Drawing.Size(100, 20);
         this.txtFirstname.TabIndex = 6;
         // 
         // l
         // 
         this.l.AutoSize = true;
         this.l.Location = new System.Drawing.Point(301, 193);
         this.l.Name = "l";
         this.l.Size = new System.Drawing.Size(55, 13);
         this.l.TabIndex = 5;
         this.l.Text = "First name";
         // 
         // btnRegisterSave
         // 
         this.btnRegisterSave.Location = new System.Drawing.Point(435, 343);
         this.btnRegisterSave.Name = "btnRegisterSave";
         this.btnRegisterSave.Size = new System.Drawing.Size(75, 23);
         this.btnRegisterSave.TabIndex = 5;
         this.btnRegisterSave.Text = "Register";
         this.btnRegisterSave.UseVisualStyleBackColor = true;
         this.btnRegisterSave.Click += new System.EventHandler(this.btnRegisterSave_Click_1);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnInventory);
         this.panel1.Controls.Add(this.btnCategory);
         this.panel1.Controls.Add(this.btnLogin);
         this.panel1.Controls.Add(this.button1);
         this.panel1.Controls.Add(this.Product);
         this.panel1.Controls.Add(this.btnDashboard);
         this.panel1.Location = new System.Drawing.Point(12, 25);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(167, 402);
         this.panel1.TabIndex = 9;
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
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(22, 165);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(117, 36);
         this.button1.TabIndex = 2;
         this.button1.Text = "Register";
         this.button1.UseVisualStyleBackColor = true;
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
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.btnRegisterSave);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtLastname);
         this.Controls.Add(this.txtFirstname);
         this.Controls.Add(this.l);
         this.Name = "Register";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Register";
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtLastname;
      private System.Windows.Forms.TextBox txtFirstname;
      private System.Windows.Forms.Label l;
      private System.Windows.Forms.Button btnRegisterSave;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnInventory;
      private System.Windows.Forms.Button btnCategory;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button Product;
      private System.Windows.Forms.Button btnDashboard;
   }
}

