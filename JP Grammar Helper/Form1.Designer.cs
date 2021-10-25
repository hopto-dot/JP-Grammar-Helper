
namespace JP_Grammar_Helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDatabase
            // 
            this.createDatabase.Location = new System.Drawing.Point(17, 17);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(86, 72);
            this.createDatabase.TabIndex = 0;
            this.createDatabase.Text = "Create Grammar Database";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createDatabase);
            this.Name = "Form1";
            this.Text = "JP Grammar Helper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createDatabase;
    }
}

