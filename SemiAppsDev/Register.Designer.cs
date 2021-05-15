
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
         this.btnBack = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(58, 192);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(84, 20);
         this.label2.TabIndex = 8;
         this.label2.Text = "Last name";
         // 
         // txtLastname
         // 
         this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtLastname.Location = new System.Drawing.Point(148, 185);
         this.txtLastname.Name = "txtLastname";
         this.txtLastname.Size = new System.Drawing.Size(100, 26);
         this.txtLastname.TabIndex = 7;
         this.txtLastname.UseSystemPasswordChar = true;
         // 
         // txtFirstname
         // 
         this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtFirstname.Location = new System.Drawing.Point(148, 140);
         this.txtFirstname.Name = "txtFirstname";
         this.txtFirstname.Size = new System.Drawing.Size(100, 26);
         this.txtFirstname.TabIndex = 6;
         // 
         // l
         // 
         this.l.AutoSize = true;
         this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.l.Location = new System.Drawing.Point(49, 140);
         this.l.Name = "l";
         this.l.Size = new System.Drawing.Size(84, 20);
         this.l.TabIndex = 5;
         this.l.Text = "First name";
         // 
         // btnRegisterSave
         // 
         this.btnRegisterSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRegisterSave.Location = new System.Drawing.Point(148, 280);
         this.btnRegisterSave.Name = "btnRegisterSave";
         this.btnRegisterSave.Size = new System.Drawing.Size(82, 31);
         this.btnRegisterSave.TabIndex = 5;
         this.btnRegisterSave.Text = "Register";
         this.btnRegisterSave.UseVisualStyleBackColor = true;
         this.btnRegisterSave.Click += new System.EventHandler(this.btnRegisterSave_Click_1);
         // 
         // btnBack
         // 
         this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBack.Location = new System.Drawing.Point(12, 12);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(75, 27);
         this.btnBack.TabIndex = 9;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(334, 404);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.btnRegisterSave);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtLastname);
         this.Controls.Add(this.txtFirstname);
         this.Controls.Add(this.l);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Register";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Register";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtLastname;
      private System.Windows.Forms.TextBox txtFirstname;
      private System.Windows.Forms.Label l;
      private System.Windows.Forms.Button btnRegisterSave;
      private System.Windows.Forms.Button btnBack;
   }
}

