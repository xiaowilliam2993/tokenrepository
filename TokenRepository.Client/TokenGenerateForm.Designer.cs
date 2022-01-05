
namespace TokenRepository.Client
{
    partial class TokenGenerateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenGenerateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTokenVal = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.databinding = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(137, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Security Key";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTokenVal);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 39);
            this.panel1.TabIndex = 5;
            // 
            // lblTokenVal
            // 
            this.lblTokenVal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTokenVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTokenVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTokenVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTokenVal.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTokenVal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTokenVal.Location = new System.Drawing.Point(0, 0);
            this.lblTokenVal.Name = "lblTokenVal";
            this.lblTokenVal.Size = new System.Drawing.Size(373, 39);
            this.lblTokenVal.TabIndex = 6;
            this.lblTokenVal.Text = "######";
            this.lblTokenVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.Turquoise;
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.Gold;
            this.btnQuery.Location = new System.Drawing.Point(271, 45);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(114, 27);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Generate";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 27);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(207, 138);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 27);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TokenGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 179);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TokenGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Token Generation";
            this.Load += new System.EventHandler(this.TokenGenerateForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TokenGenerateForm_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTokenVal;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.BindingSource databinding;
    }
}