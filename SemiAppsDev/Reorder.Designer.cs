
namespace SemiAppsDev
{
   partial class Reorder
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
         this.btnReorder = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtReorder = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(191, 74);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(160, 33);
         this.label2.TabIndex = 1;
         this.label2.Text = "REORDER";
         // 
         // btnReorder
         // 
         this.btnReorder.Location = new System.Drawing.Point(259, 406);
         this.btnReorder.Name = "btnReorder";
         this.btnReorder.Size = new System.Drawing.Size(75, 23);
         this.btnReorder.TabIndex = 2;
         this.btnReorder.Text = "Reorder";
         this.btnReorder.UseVisualStyleBackColor = true;
         this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(179, 228);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(74, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Reorder stock";
         // 
         // txtReorder
         // 
         this.txtReorder.Location = new System.Drawing.Point(259, 225);
         this.txtReorder.Name = "txtReorder";
         this.txtReorder.Size = new System.Drawing.Size(100, 20);
         this.txtReorder.TabIndex = 4;
         // 
         // Reorder
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(564, 485);
         this.Controls.Add(this.txtReorder);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnReorder);
         this.Controls.Add(this.label2);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Reorder";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Reorder";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnReorder;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtReorder;
   }
}