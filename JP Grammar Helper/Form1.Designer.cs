
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
            this.lbGrammar = new System.Windows.Forms.ListBox();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createDatabase
            // 
            this.createDatabase.Location = new System.Drawing.Point(12, 12);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(206, 31);
            this.createDatabase.TabIndex = 0;
            this.createDatabase.Text = "Create Grammar Database";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // lbGrammar
            // 
            this.lbGrammar.FormattingEnabled = true;
            this.lbGrammar.ItemHeight = 20;
            this.lbGrammar.Location = new System.Drawing.Point(12, 49);
            this.lbGrammar.Name = "lbGrammar";
            this.lbGrammar.Size = new System.Drawing.Size(438, 384);
            this.lbGrammar.TabIndex = 1;
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "N5",
            "N4",
            "N3",
            "N2",
            "N1"});
            this.cbbLevel.Location = new System.Drawing.Point(224, 14);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(74, 28);
            this.cbbLevel.TabIndex = 2;
            this.cbbLevel.Text = "N5";
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.lbGrammar);
            this.Controls.Add(this.createDatabase);
            this.Name = "Form1";
            this.Text = "li";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createDatabase;
        private System.Windows.Forms.ListBox lbGrammar;
        private System.Windows.Forms.ComboBox cbbLevel;
    }
}

