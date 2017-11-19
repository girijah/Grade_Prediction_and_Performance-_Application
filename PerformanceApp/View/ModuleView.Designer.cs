namespace PerformanceApp
{
    partial class ModuleView
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblModuleHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfAssess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(47, 91);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // lblModuleHead
            // 
            this.lblModuleHead.AutoSize = true;
            this.lblModuleHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleHead.Location = new System.Drawing.Point(89, 38);
            this.lblModuleHead.Name = "lblModuleHead";
            this.lblModuleHead.Size = new System.Drawing.Size(53, 16);
            this.lblModuleHead.TabIndex = 2;
            this.lblModuleHead.Text = "Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(47, 163);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = "Credits";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(114, 91);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 5;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(114, 163);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCredits.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "No.Of.Assessments";
            // 
            // txtNoOfAssess
            // 
            this.txtNoOfAssess.Location = new System.Drawing.Point(167, 206);
            this.txtNoOfAssess.Name = "txtNoOfAssess";
            this.txtNoOfAssess.Size = new System.Drawing.Size(47, 20);
            this.txtNoOfAssess.TabIndex = 9;
            // 
            // ModuleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 298);
            this.Controls.Add(this.txtNoOfAssess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModuleHead);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.button1);
            this.Name = "ModuleView";
            this.Text = "New Module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblModuleHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoOfAssess;
    }
}