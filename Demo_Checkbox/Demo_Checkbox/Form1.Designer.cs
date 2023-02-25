namespace Demo_Checkbox
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
            this.checkGt = new System.Windows.Forms.CheckBox();
            this.buttonClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkGt
            // 
            this.checkGt.AutoSize = true;
            this.checkGt.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkGt.Location = new System.Drawing.Point(153, 163);
            this.checkGt.Name = "checkGt";
            this.checkGt.Size = new System.Drawing.Size(79, 24);
            this.checkGt.TabIndex = 0;
            this.checkGt.Text = "Là nam";
            this.checkGt.UseVisualStyleBackColor = true;
            this.checkGt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkGt.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            this.checkGt.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(153, 217);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(94, 29);
            this.buttonClick.TabIndex = 1;
            this.buttonClick.Text = "Click";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(153, 130);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.checkGt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkGt;
        private Button buttonClick;
        private Label label1;
        private TextBox textName;
    }
}