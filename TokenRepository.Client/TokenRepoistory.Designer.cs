
namespace TokenRepository.Client
{
    partial class TokenRepositoryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenRepositoryForm));
            this.lblSearchTokenCaption = new System.Windows.Forms.Label();
            this.tboxSearchTokenVal = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lnkAdd = new System.Windows.Forms.LinkLabel();
            this.gboxSerachResult = new System.Windows.Forms.GroupBox();
            this.lblTokenIDVal = new System.Windows.Forms.Label();
            this.lnkSetting = new System.Windows.Forms.LinkLabel();
            this.lblTokenIDCaption = new System.Windows.Forms.Label();
            this.lblPromptVal = new System.Windows.Forms.Label();
            this.lblPromptCaption = new System.Windows.Forms.Label();
            this.lblSecurityLevelVal = new System.Windows.Forms.Label();
            this.lblSecurityLevelCaption = new System.Windows.Forms.Label();
            this.lnkShowOrHide = new System.Windows.Forms.LinkLabel();
            this.lblTokenCaption = new System.Windows.Forms.Label();
            this.lblTokenVal = new System.Windows.Forms.Label();
            this.gboxEnabledDateControlStrategy = new System.Windows.Forms.GroupBox();
            this.lblEnabledDateControlStrategyVal = new System.Windows.Forms.Label();
            this.lblEnabledDateCaption = new System.Windows.Forms.Label();
            this.lblEnabledDateControlStrategyCaption = new System.Windows.Forms.Label();
            this.lblEnabledDateVal = new System.Windows.Forms.Label();
            this.databinding = new System.Windows.Forms.BindingSource(this.components);
            this.gboxSerachResult.SuspendLayout();
            this.gboxEnabledDateControlStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchTokenCaption
            // 
            this.lblSearchTokenCaption.AutoSize = true;
            this.lblSearchTokenCaption.Location = new System.Drawing.Point(138, 27);
            this.lblSearchTokenCaption.Name = "lblSearchTokenCaption";
            this.lblSearchTokenCaption.Size = new System.Drawing.Size(87, 17);
            this.lblSearchTokenCaption.TabIndex = 0;
            this.lblSearchTokenCaption.Text = "Search Token";
            // 
            // tboxSearchTokenVal
            // 
            this.tboxSearchTokenVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSearchTokenVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxSearchTokenVal.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxSearchTokenVal.Location = new System.Drawing.Point(240, 23);
            this.tboxSearchTokenVal.Name = "tboxSearchTokenVal";
            this.tboxSearchTokenVal.Size = new System.Drawing.Size(334, 25);
            this.tboxSearchTokenVal.TabIndex = 1;
            this.tboxSearchTokenVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxSearchTokenVal_KeyUp);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuery.Location = new System.Drawing.Point(580, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 27);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lnkAdd
            // 
            this.lnkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAdd.AutoSize = true;
            this.lnkAdd.Location = new System.Drawing.Point(661, 27);
            this.lnkAdd.Name = "lnkAdd";
            this.lnkAdd.Size = new System.Drawing.Size(41, 17);
            this.lnkAdd.TabIndex = 3;
            this.lnkAdd.TabStop = true;
            this.lnkAdd.Text = "Add...";
            this.lnkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdd_LinkClicked);
            // 
            // gboxSerachResult
            // 
            this.gboxSerachResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxSerachResult.Controls.Add(this.lblTokenIDVal);
            this.gboxSerachResult.Controls.Add(this.lnkSetting);
            this.gboxSerachResult.Controls.Add(this.lblTokenIDCaption);
            this.gboxSerachResult.Controls.Add(this.lblPromptVal);
            this.gboxSerachResult.Controls.Add(this.lblPromptCaption);
            this.gboxSerachResult.Controls.Add(this.lblSecurityLevelVal);
            this.gboxSerachResult.Controls.Add(this.lblSecurityLevelCaption);
            this.gboxSerachResult.Controls.Add(this.lnkShowOrHide);
            this.gboxSerachResult.Controls.Add(this.lblTokenCaption);
            this.gboxSerachResult.Controls.Add(this.lblTokenVal);
            this.gboxSerachResult.Controls.Add(this.gboxEnabledDateControlStrategy);
            this.gboxSerachResult.Location = new System.Drawing.Point(12, 54);
            this.gboxSerachResult.Name = "gboxSerachResult";
            this.gboxSerachResult.Size = new System.Drawing.Size(749, 239);
            this.gboxSerachResult.TabIndex = 4;
            this.gboxSerachResult.TabStop = false;
            this.gboxSerachResult.Text = "Search Result";
            // 
            // lblTokenIDVal
            // 
            this.lblTokenIDVal.AutoSize = true;
            this.lblTokenIDVal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTokenIDVal.Location = new System.Drawing.Point(225, 28);
            this.lblTokenIDVal.Name = "lblTokenIDVal";
            this.lblTokenIDVal.Size = new System.Drawing.Size(46, 17);
            this.lblTokenIDVal.TabIndex = 6;
            this.lblTokenIDVal.Text = "Token";
            // 
            // lnkSetting
            // 
            this.lnkSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSetting.AutoSize = true;
            this.lnkSetting.Location = new System.Drawing.Point(649, 28);
            this.lnkSetting.Name = "lnkSetting";
            this.lnkSetting.Size = new System.Drawing.Size(57, 17);
            this.lnkSetting.TabIndex = 7;
            this.lnkSetting.TabStop = true;
            this.lnkSetting.Text = "Setting...";
            this.lnkSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetting_LinkClicked);
            // 
            // lblTokenIDCaption
            // 
            this.lblTokenIDCaption.AutoSize = true;
            this.lblTokenIDCaption.Location = new System.Drawing.Point(152, 28);
            this.lblTokenIDCaption.Name = "lblTokenIDCaption";
            this.lblTokenIDCaption.Size = new System.Drawing.Size(61, 17);
            this.lblTokenIDCaption.TabIndex = 5;
            this.lblTokenIDCaption.Text = "Token ID";
            // 
            // lblPromptVal
            // 
            this.lblPromptVal.Location = new System.Drawing.Point(225, 199);
            this.lblPromptVal.Name = "lblPromptVal";
            this.lblPromptVal.Size = new System.Drawing.Size(418, 22);
            this.lblPromptVal.TabIndex = 19;
            this.lblPromptVal.Text = "...";
            // 
            // lblPromptCaption
            // 
            this.lblPromptCaption.AutoSize = true;
            this.lblPromptCaption.Location = new System.Drawing.Point(159, 201);
            this.lblPromptCaption.Name = "lblPromptCaption";
            this.lblPromptCaption.Size = new System.Drawing.Size(51, 17);
            this.lblPromptCaption.TabIndex = 18;
            this.lblPromptCaption.Text = "Prompt";
            // 
            // lblSecurityLevelVal
            // 
            this.lblSecurityLevelVal.AutoSize = true;
            this.lblSecurityLevelVal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecurityLevelVal.Location = new System.Drawing.Point(225, 89);
            this.lblSecurityLevelVal.Name = "lblSecurityLevelVal";
            this.lblSecurityLevelVal.Size = new System.Drawing.Size(25, 17);
            this.lblSecurityLevelVal.TabIndex = 12;
            this.lblSecurityLevelVal.Text = "N1";
            // 
            // lblSecurityLevelCaption
            // 
            this.lblSecurityLevelCaption.AutoSize = true;
            this.lblSecurityLevelCaption.Location = new System.Drawing.Point(127, 89);
            this.lblSecurityLevelCaption.Name = "lblSecurityLevelCaption";
            this.lblSecurityLevelCaption.Size = new System.Drawing.Size(86, 17);
            this.lblSecurityLevelCaption.TabIndex = 11;
            this.lblSecurityLevelCaption.Text = "Security Level";
            // 
            // lnkShowOrHide
            // 
            this.lnkShowOrHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkShowOrHide.AutoSize = true;
            this.lnkShowOrHide.Location = new System.Drawing.Point(649, 58);
            this.lnkShowOrHide.Name = "lnkShowOrHide";
            this.lnkShowOrHide.Size = new System.Drawing.Size(85, 17);
            this.lnkShowOrHide.TabIndex = 10;
            this.lnkShowOrHide.TabStop = true;
            this.lnkShowOrHide.Text = "Show or hide";
            this.lnkShowOrHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowOrHide_LinkClicked);
            // 
            // lblTokenCaption
            // 
            this.lblTokenCaption.AutoSize = true;
            this.lblTokenCaption.Location = new System.Drawing.Point(168, 58);
            this.lblTokenCaption.Name = "lblTokenCaption";
            this.lblTokenCaption.Size = new System.Drawing.Size(44, 17);
            this.lblTokenCaption.TabIndex = 8;
            this.lblTokenCaption.Text = "Token";
            // 
            // lblTokenVal
            // 
            this.lblTokenVal.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTokenVal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTokenVal.Location = new System.Drawing.Point(223, 53);
            this.lblTokenVal.Name = "lblTokenVal";
            this.lblTokenVal.Size = new System.Drawing.Size(319, 32);
            this.lblTokenVal.TabIndex = 9;
            this.lblTokenVal.Text = "######################";
            this.lblTokenVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gboxEnabledDateControlStrategy
            // 
            this.gboxEnabledDateControlStrategy.Controls.Add(this.lblEnabledDateControlStrategyVal);
            this.gboxEnabledDateControlStrategy.Controls.Add(this.lblEnabledDateCaption);
            this.gboxEnabledDateControlStrategy.Controls.Add(this.lblEnabledDateControlStrategyCaption);
            this.gboxEnabledDateControlStrategy.Controls.Add(this.lblEnabledDateVal);
            this.gboxEnabledDateControlStrategy.Location = new System.Drawing.Point(18, 109);
            this.gboxEnabledDateControlStrategy.Name = "gboxEnabledDateControlStrategy";
            this.gboxEnabledDateControlStrategy.Size = new System.Drawing.Size(625, 80);
            this.gboxEnabledDateControlStrategy.TabIndex = 13;
            this.gboxEnabledDateControlStrategy.TabStop = false;
            // 
            // lblEnabledDateControlStrategyVal
            // 
            this.lblEnabledDateControlStrategyVal.AutoSize = true;
            this.lblEnabledDateControlStrategyVal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnabledDateControlStrategyVal.Location = new System.Drawing.Point(207, 23);
            this.lblEnabledDateControlStrategyVal.Name = "lblEnabledDateControlStrategyVal";
            this.lblEnabledDateControlStrategyVal.Size = new System.Drawing.Size(16, 17);
            this.lblEnabledDateControlStrategyVal.TabIndex = 15;
            this.lblEnabledDateControlStrategyVal.Text = "Y";
            // 
            // lblEnabledDateCaption
            // 
            this.lblEnabledDateCaption.AutoSize = true;
            this.lblEnabledDateCaption.Location = new System.Drawing.Point(110, 50);
            this.lblEnabledDateCaption.Name = "lblEnabledDateCaption";
            this.lblEnabledDateCaption.Size = new System.Drawing.Size(85, 17);
            this.lblEnabledDateCaption.TabIndex = 16;
            this.lblEnabledDateCaption.Text = "Enabled date";
            // 
            // lblEnabledDateControlStrategyCaption
            // 
            this.lblEnabledDateControlStrategyCaption.AutoSize = true;
            this.lblEnabledDateControlStrategyCaption.Location = new System.Drawing.Point(13, 21);
            this.lblEnabledDateControlStrategyCaption.Name = "lblEnabledDateControlStrategyCaption";
            this.lblEnabledDateControlStrategyCaption.Size = new System.Drawing.Size(181, 17);
            this.lblEnabledDateControlStrategyCaption.TabIndex = 14;
            this.lblEnabledDateControlStrategyCaption.Text = "Enabled date control strategy";
            // 
            // lblEnabledDateVal
            // 
            this.lblEnabledDateVal.AutoSize = true;
            this.lblEnabledDateVal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnabledDateVal.Location = new System.Drawing.Point(207, 50);
            this.lblEnabledDateVal.Name = "lblEnabledDateVal";
            this.lblEnabledDateVal.Size = new System.Drawing.Size(126, 17);
            this.lblEnabledDateVal.TabIndex = 17;
            this.lblEnabledDateVal.Text = "1900-01-01 00:00:00";
            // 
            // TokenRepositoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 305);
            this.Controls.Add(this.gboxSerachResult);
            this.Controls.Add(this.lnkAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tboxSearchTokenVal);
            this.Controls.Add(this.lblSearchTokenCaption);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TokenRepositoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Repository";
            this.Load += new System.EventHandler(this.TokenRepositoryForm_Load);
            this.gboxSerachResult.ResumeLayout(false);
            this.gboxSerachResult.PerformLayout();
            this.gboxEnabledDateControlStrategy.ResumeLayout(false);
            this.gboxEnabledDateControlStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchTokenCaption;
        private System.Windows.Forms.TextBox tboxSearchTokenVal;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.LinkLabel lnkAdd;
        private System.Windows.Forms.GroupBox gboxSerachResult;
        private System.Windows.Forms.Label lblTokenCaption;
        private System.Windows.Forms.Label lblTokenVal;
        private System.Windows.Forms.Label lblPromptCaption;
        private System.Windows.Forms.Label lblSecurityLevelVal;
        private System.Windows.Forms.Label lblSecurityLevelCaption;
        private System.Windows.Forms.Label lblEnabledDateVal;
        private System.Windows.Forms.Label lblEnabledDateCaption;
        private System.Windows.Forms.LinkLabel lnkShowOrHide;
        private System.Windows.Forms.Label lblTokenIDVal;
        private System.Windows.Forms.LinkLabel lnkSetting;
        private System.Windows.Forms.Label lblTokenIDCaption;
        private System.Windows.Forms.Label lblPromptVal;
        private System.Windows.Forms.Label lblEnabledDateControlStrategyVal;
        private System.Windows.Forms.Label lblEnabledDateControlStrategyCaption;
        private System.Windows.Forms.GroupBox gboxEnabledDateControlStrategy;
        private System.Windows.Forms.BindingSource databinding;
    }
}

