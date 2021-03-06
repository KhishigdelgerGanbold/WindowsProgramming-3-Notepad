
namespace Khishigdelger_NotepadCSharp
{
    partial class CustomDialogBox
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(12, 176);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Тийм";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(247, 176);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 1;
            this.No.Text = "Үгүй";
            this.No.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 62);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Файланд өөрчлөлт орсон байна,              Та ажилаа гарахаас өмнө хадгалах уу?  " +
    "  Тийм - Xадгалах, Үгүй - Шууд гарах";
            // 
            // CustomDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "CustomDialogBox";
            this.Text = "Та гарахдаа итгэлтэй байна уу?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.TextBox textBox1;
    }
}