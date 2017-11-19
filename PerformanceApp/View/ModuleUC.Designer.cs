namespace PerformanceApp
{
    partial class ModuleUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLay = new System.Windows.Forms.FlowLayoutPanel();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.txtModCredit = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLay
            // 
            this.flowLay.AutoScroll = true;
            this.flowLay.Location = new System.Drawing.Point(12, 55);
            this.flowLay.Name = "flowLay";
            this.flowLay.Size = new System.Drawing.Size(562, 157);
            this.flowLay.TabIndex = 1;
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(12, 27);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(109, 20);
            this.txtModCode.TabIndex = 2;
            this.txtModCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModCredit
            // 
            this.txtModCredit.Location = new System.Drawing.Point(465, 27);
            this.txtModCredit.Name = "txtModCredit";
            this.txtModCredit.Size = new System.Drawing.Size(109, 20);
            this.txtModCredit.TabIndex = 3;
            this.txtModCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(127, 27);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(332, 20);
            this.txtModName.TabIndex = 4;
            this.txtModName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(127, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Module Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(465, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 218);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(472, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(519, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModuleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.txtModCredit);
            this.Controls.Add(this.txtModCode);
            this.Controls.Add(this.flowLay);
            this.Name = "ModuleUC";
            this.Size = new System.Drawing.Size(590, 248);
            this.Load += new System.EventHandler(this.ModuleUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLay;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.TextBox txtModCredit;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
    }
}
