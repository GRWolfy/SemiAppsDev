
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
         this.linkLabel1 = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // l
         // 
         this.l.AutoSize = true;
         this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.l.Location = new System.Drawing.Point(45, 113);
         this.l.Name = "l";
         this.l.Size = new System.Drawing.Size(83, 20);
         this.l.TabIndex = 0;
         this.l.Text = "Username";
         // 
         // btnLoginSave
         // 
         this.btnLoginSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLoginSave.Location = new System.Drawing.Point(125, 264);
         this.btnLoginSave.Name = "btnLoginSave";
         this.btnLoginSave.Size = new System.Drawing.Size(75, 30);
         this.btnLoginSave.TabIndex = 1;
         this.btnLoginSave.Text = "Login";
         this.btnLoginSave.UseVisualStyleBackColor = true;
         this.btnLoginSave.Click += new System.EventHandler(this.btnLoginSave_Click_1);
         // 
         // txtfirstname
         // 
         this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtfirstname.Location = new System.Drawing.Point(143, 112);
         this.txtfirstname.Name = "txtfirstname";
         this.txtfirstname.Size = new System.Drawing.Size(120, 26);
         this.txtfirstname.TabIndex = 2;
         // 
         // txtlastname
         // 
         this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtlastname.Location = new System.Drawing.Point(143, 157);
         this.txtlastname.Name = "txtlastname";
         this.txtlastname.Size = new System.Drawing.Size(120, 26);
         this.txtlastname.TabIndex = 3;
         this.txtlastname.UseSystemPasswordChar = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(54, 165);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 20);
         this.label2.TabIndex = 4;
         this.label2.Text = "Password";
         // 
         // linkLabel1
         // 
         this.linkLabel1.AutoSize = true;
         this.linkLabel1.Location = new System.Drawing.Point(89, 326);
         this.linkLabel1.Name = "linkLabel1";
         this.linkLabel1.Size = new System.Drawing.Size(146, 13);
         this.linkLabel1.TabIndex = 5;
         this.linkLabel1.TabStop = true;
         this.linkLabel1.Text = "Need an account? Click here";
         this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(334, 404);
         this.Controls.Add(this.linkLabel1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtlastname);
         this.Controls.Add(this.txtfirstname);
         this.Controls.Add(this.btnLoginSave);
         this.Controls.Add(this.l);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label l;
      private System.Windows.Forms.Button btnLoginSave;
      private System.Windows.Forms.TextBox txtfirstname;
      private System.Windows.Forms.TextBox txtlastname;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.LinkLabel linkLabel1;
   }
}