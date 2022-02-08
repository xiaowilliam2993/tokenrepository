
namespace TokenRepository.Client
{
    partial class TokenDocumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenDocumentForm));
            this.gboxMaintainMetadata = new System.Windows.Forms.GroupBox();
            this.gboxSecurityStrategy = new System.Windows.Forms.GroupBox();
            this.lblSecurityKey = new System.Windows.Forms.Label();
            this.combSecurityKey = new System.Windows.Forms.ComboBox();
            this.lblSecurityLabel = new System.Windows.Forms.Label();
            this.combSecurityLevel = new System.Windows.Forms.ComboBox();
            this.lblTokenLength = new System.Windows.Forms.Label();
            this.cboxShowOrHideToken = new System.Windows.Forms.CheckBox();
            this.gboxManagementProperties = new System.Windows.Forms.GroupBox();
            this.tboxModifyDate = new System.Windows.Forms.TextBox();
            this.lblModifyDate = new System.Windows.Forms.Label();
            this.tboxCreateDate = new System.Windows.Forms.TextBox();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lnkGenerateToken = new System.Windows.Forms.LinkLabel();
            this.tboxRemark = new System.Windows.Forms.TextBox();
            this.tboxPrompt = new System.Windows.Forms.TextBox();
            this.tboxToken = new System.Windows.Forms.TextBox();
            this.tboxTokenID = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblTokenIDCaption = new System.Windows.Forms.Label();
            this.lblTokenCaption = new System.Windows.Forms.Label();
            this.lblRemarkCaption = new System.Windows.Forms.Label();
            this.gboxTokenControlStrategy = new System.Windows.Forms.GroupBox();
            this.dtpickerEnabledTime = new System.Windows.Forms.DateTimePicker();
            this.dtpickerEnabledDate = new System.Windows.Forms.DateTimePicker();
            this.lblEnabledDate = new System.Windows.Forms.Label();
            this.cboxEnabledDateControlStrategy = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.databinding = new System.Windows.Forms.BindingSource(this.components);
            this.gboxMaintainMetadata.SuspendLayout();
            this.gboxSecurityStrategy.SuspendLayout();
            this.gboxManagementProperties.SuspendLayout();
            this.gboxTokenControlStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxMaintainMetadata
            // 
            this.gboxMaintainMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxMaintainMetadata.Controls.Add(this.gboxSecurityStrategy);
            this.gboxMaintainMetadata.Controls.Add(this.lblTokenLength);
            this.gboxMaintainMetadata.Controls.Add(this.cboxShowOrHideToken);
            this.gboxMaintainMetadata.Controls.Add(this.gboxManagementProperties);
            this.gboxMaintainMetadata.Controls.Add(this.lnkGenerateToken);
            this.gboxMaintainMetadata.Controls.Add(this.tboxRemark);
            this.gboxMaintainMetadata.Controls.Add(this.tboxPrompt);
            this.gboxMaintainMetadata.Controls.Add(this.tboxToken);
            this.gboxMaintainMetadata.Controls.Add(this.tboxTokenID);
            this.gboxMaintainMetadata.Controls.Add(this.lblRemark);
            this.gboxMaintainMetadata.Controls.Add(this.lblTokenIDCaption);
            this.gboxMaintainMetadata.Controls.Add(this.lblTokenCaption);
            this.gboxMaintainMetadata.Controls.Add(this.lblRemarkCaption);
            this.gboxMaintainMetadata.Controls.Add(this.gboxTokenControlStrategy);
            this.gboxMaintainMetadata.Location = new System.Drawing.Point(12, 12);
            this.gboxMaintainMetadata.Name = "gboxMaintainMetadata";
            this.gboxMaintainMetadata.Size = new System.Drawing.Size(555, 578);
            this.gboxMaintainMetadata.TabIndex = 0;
            this.gboxMaintainMetadata.TabStop = false;
            this.gboxMaintainMetadata.Text = "Maintain token metadata";
            // 
            // gboxSecurityStrategy
            // 
            this.gboxSecurityStrategy.Controls.Add(this.lblSecurityKey);
            this.gboxSecurityStrategy.Controls.Add(this.combSecurityKey);
            this.gboxSecurityStrategy.Controls.Add(this.lblSecurityLabel);
            this.gboxSecurityStrategy.Controls.Add(this.combSecurityLevel);
            this.gboxSecurityStrategy.Location = new System.Drawing.Point(19, 60);
            this.gboxSecurityStrategy.Name = "gboxSecurityStrategy";
            this.gboxSecurityStrategy.Size = new System.Drawing.Size(521, 90);
            this.gboxSecurityStrategy.TabIndex = 20;
            this.gboxSecurityStrategy.TabStop = false;
            this.gboxSecurityStrategy.Text = "Security strategy";
            // 
            // lblSecurityKey
            // 
            this.lblSecurityKey.AutoSize = true;
            this.lblSecurityKey.Location = new System.Drawing.Point(290, 26);
            this.lblSecurityKey.Name = "lblSecurityKey";
            this.lblSecurityKey.Size = new System.Drawing.Size(77, 17);
            this.lblSecurityKey.TabIndex = 23;
            this.lblSecurityKey.Text = "Security key";
            // 
            // combSecurityKey
            // 
            this.combSecurityKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combSecurityKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSecurityKey.FormattingEnabled = true;
            this.combSecurityKey.Location = new System.Drawing.Point(293, 46);
            this.combSecurityKey.Name = "combSecurityKey";
            this.combSecurityKey.Size = new System.Drawing.Size(152, 25);
            this.combSecurityKey.TabIndex = 22;
            // 
            // lblSecurityLabel
            // 
            this.lblSecurityLabel.AutoSize = true;
            this.lblSecurityLabel.Location = new System.Drawing.Point(107, 26);
            this.lblSecurityLabel.Name = "lblSecurityLabel";
            this.lblSecurityLabel.Size = new System.Drawing.Size(37, 17);
            this.lblSecurityLabel.TabIndex = 21;
            this.lblSecurityLabel.Text = "Level";
            // 
            // combSecurityLevel
            // 
            this.combSecurityLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combSecurityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSecurityLevel.FormattingEnabled = true;
            this.combSecurityLevel.Location = new System.Drawing.Point(110, 46);
            this.combSecurityLevel.Name = "combSecurityLevel";
            this.combSecurityLevel.Size = new System.Drawing.Size(157, 25);
            this.combSecurityLevel.TabIndex = 4;
            // 
            // lblTokenLength
            // 
            this.lblTokenLength.AutoSize = true;
            this.lblTokenLength.Location = new System.Drawing.Point(126, 208);
            this.lblTokenLength.Name = "lblTokenLength";
            this.lblTokenLength.Size = new System.Drawing.Size(98, 17);
            this.lblTokenLength.TabIndex = 19;
            this.lblTokenLength.Text = "Token length: 0";
            // 
            // cboxShowOrHideToken
            // 
            this.cboxShowOrHideToken.AutoSize = true;
            this.cboxShowOrHideToken.Location = new System.Drawing.Point(129, 156);
            this.cboxShowOrHideToken.Name = "cboxShowOrHideToken";
            this.cboxShowOrHideToken.Size = new System.Drawing.Size(141, 21);
            this.cboxShowOrHideToken.TabIndex = 5;
            this.cboxShowOrHideToken.Text = "Show or hide token";
            this.cboxShowOrHideToken.UseVisualStyleBackColor = true;
            // 
            // gboxManagementProperties
            // 
            this.gboxManagementProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxManagementProperties.Controls.Add(this.tboxModifyDate);
            this.gboxManagementProperties.Controls.Add(this.lblModifyDate);
            this.gboxManagementProperties.Controls.Add(this.tboxCreateDate);
            this.gboxManagementProperties.Controls.Add(this.lblCreateDate);
            this.gboxManagementProperties.Location = new System.Drawing.Point(19, 465);
            this.gboxManagementProperties.Name = "gboxManagementProperties";
            this.gboxManagementProperties.Size = new System.Drawing.Size(521, 98);
            this.gboxManagementProperties.TabIndex = 18;
            this.gboxManagementProperties.TabStop = false;
            this.gboxManagementProperties.Text = "Management properties";
            // 
            // tboxModifyDate
            // 
            this.tboxModifyDate.Location = new System.Drawing.Point(110, 62);
            this.tboxModifyDate.Name = "tboxModifyDate";
            this.tboxModifyDate.ReadOnly = true;
            this.tboxModifyDate.Size = new System.Drawing.Size(157, 23);
            this.tboxModifyDate.TabIndex = 22;
            // 
            // lblModifyDate
            // 
            this.lblModifyDate.AutoSize = true;
            this.lblModifyDate.Location = new System.Drawing.Point(17, 65);
            this.lblModifyDate.Name = "lblModifyDate";
            this.lblModifyDate.Size = new System.Drawing.Size(79, 17);
            this.lblModifyDate.TabIndex = 21;
            this.lblModifyDate.Text = "Modify date";
            // 
            // tboxCreateDate
            // 
            this.tboxCreateDate.Location = new System.Drawing.Point(110, 33);
            this.tboxCreateDate.Name = "tboxCreateDate";
            this.tboxCreateDate.ReadOnly = true;
            this.tboxCreateDate.Size = new System.Drawing.Size(157, 23);
            this.tboxCreateDate.TabIndex = 20;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(22, 36);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(76, 17);
            this.lblCreateDate.TabIndex = 19;
            this.lblCreateDate.Text = "Create date";
            // 
            // lnkGenerateToken
            // 
            this.lnkGenerateToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGenerateToken.AutoSize = true;
            this.lnkGenerateToken.Location = new System.Drawing.Point(470, 185);
            this.lnkGenerateToken.Name = "lnkGenerateToken";
            this.lnkGenerateToken.Size = new System.Drawing.Size(70, 17);
            this.lnkGenerateToken.TabIndex = 8;
            this.lnkGenerateToken.TabStop = true;
            this.lnkGenerateToken.Text = "Generate...";
            this.lnkGenerateToken.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateToken_LinkClicked);
            // 
            // tboxRemark
            // 
            this.tboxRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxRemark.Location = new System.Drawing.Point(129, 364);
            this.tboxRemark.Multiline = true;
            this.tboxRemark.Name = "tboxRemark";
            this.tboxRemark.Size = new System.Drawing.Size(335, 93);
            this.tboxRemark.TabIndex = 17;
            // 
            // tboxPrompt
            // 
            this.tboxPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxPrompt.Location = new System.Drawing.Point(129, 335);
            this.tboxPrompt.Name = "tboxPrompt";
            this.tboxPrompt.Size = new System.Drawing.Size(335, 23);
            this.tboxPrompt.TabIndex = 15;
            // 
            // tboxToken
            // 
            this.tboxToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxToken.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tboxToken.Location = new System.Drawing.Point(129, 182);
            this.tboxToken.Name = "tboxToken";
            this.tboxToken.PasswordChar = '※';
            this.tboxToken.Size = new System.Drawing.Size(335, 23);
            this.tboxToken.TabIndex = 7;
            // 
            // tboxTokenID
            // 
            this.tboxTokenID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTokenID.BackColor = System.Drawing.SystemColors.Info;
            this.tboxTokenID.Location = new System.Drawing.Point(129, 31);
            this.tboxTokenID.Name = "tboxTokenID";
            this.tboxTokenID.Size = new System.Drawing.Size(335, 23);
            this.tboxTokenID.TabIndex = 2;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(64, 367);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(53, 17);
            this.lblRemark.TabIndex = 16;
            this.lblRemark.Text = "Remark";
            // 
            // lblTokenIDCaption
            // 
            this.lblTokenIDCaption.AutoSize = true;
            this.lblTokenIDCaption.Location = new System.Drawing.Point(56, 34);
            this.lblTokenIDCaption.Name = "lblTokenIDCaption";
            this.lblTokenIDCaption.Size = new System.Drawing.Size(61, 17);
            this.lblTokenIDCaption.TabIndex = 1;
            this.lblTokenIDCaption.Text = "Token ID";
            // 
            // lblTokenCaption
            // 
            this.lblTokenCaption.AutoSize = true;
            this.lblTokenCaption.Location = new System.Drawing.Point(73, 185);
            this.lblTokenCaption.Name = "lblTokenCaption";
            this.lblTokenCaption.Size = new System.Drawing.Size(44, 17);
            this.lblTokenCaption.TabIndex = 6;
            this.lblTokenCaption.Text = "Token";
            // 
            // lblRemarkCaption
            // 
            this.lblRemarkCaption.AutoSize = true;
            this.lblRemarkCaption.Location = new System.Drawing.Point(65, 338);
            this.lblRemarkCaption.Name = "lblRemarkCaption";
            this.lblRemarkCaption.Size = new System.Drawing.Size(51, 17);
            this.lblRemarkCaption.TabIndex = 14;
            this.lblRemarkCaption.Text = "Prompt";
            // 
            // gboxTokenControlStrategy
            // 
            this.gboxTokenControlStrategy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxTokenControlStrategy.Controls.Add(this.dtpickerEnabledTime);
            this.gboxTokenControlStrategy.Controls.Add(this.dtpickerEnabledDate);
            this.gboxTokenControlStrategy.Controls.Add(this.lblEnabledDate);
            this.gboxTokenControlStrategy.Controls.Add(this.cboxEnabledDateControlStrategy);
            this.gboxTokenControlStrategy.Location = new System.Drawing.Point(19, 241);
            this.gboxTokenControlStrategy.Name = "gboxTokenControlStrategy";
            this.gboxTokenControlStrategy.Size = new System.Drawing.Size(521, 83);
            this.gboxTokenControlStrategy.TabIndex = 9;
            this.gboxTokenControlStrategy.TabStop = false;
            this.gboxTokenControlStrategy.Text = "Token control strategy";
            // 
            // dtpickerEnabledTime
            // 
            this.dtpickerEnabledTime.Enabled = false;
            this.dtpickerEnabledTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpickerEnabledTime.Location = new System.Drawing.Point(226, 49);
            this.dtpickerEnabledTime.Name = "dtpickerEnabledTime";
            this.dtpickerEnabledTime.Size = new System.Drawing.Size(87, 23);
            this.dtpickerEnabledTime.TabIndex = 13;
            // 
            // dtpickerEnabledDate
            // 
            this.dtpickerEnabledDate.Enabled = false;
            this.dtpickerEnabledDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerEnabledDate.Location = new System.Drawing.Point(110, 49);
            this.dtpickerEnabledDate.Name = "dtpickerEnabledDate";
            this.dtpickerEnabledDate.Size = new System.Drawing.Size(110, 23);
            this.dtpickerEnabledDate.TabIndex = 12;
            // 
            // lblEnabledDate
            // 
            this.lblEnabledDate.AutoSize = true;
            this.lblEnabledDate.Location = new System.Drawing.Point(12, 52);
            this.lblEnabledDate.Name = "lblEnabledDate";
            this.lblEnabledDate.Size = new System.Drawing.Size(85, 17);
            this.lblEnabledDate.TabIndex = 11;
            this.lblEnabledDate.Text = "Enabled date";
            // 
            // cboxEnabledDateControlStrategy
            // 
            this.cboxEnabledDateControlStrategy.AutoSize = true;
            this.cboxEnabledDateControlStrategy.Location = new System.Drawing.Point(110, 22);
            this.cboxEnabledDateControlStrategy.Name = "cboxEnabledDateControlStrategy";
            this.cboxEnabledDateControlStrategy.Size = new System.Drawing.Size(200, 21);
            this.cboxEnabledDateControlStrategy.TabIndex = 10;
            this.cboxEnabledDateControlStrategy.Text = "Enabled date control strategy";
            this.cboxEnabledDateControlStrategy.UseVisualStyleBackColor = true;
            this.cboxEnabledDateControlStrategy.CheckedChanged += new System.EventHandler(this.cboxEnabledDateControlStrategy_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(386, 596);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 27);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(481, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 27);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TokenDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 633);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gboxMaintainMetadata);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TokenDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TokenDocumentForm_FormClosing);
            this.Load += new System.EventHandler(this.TokenDocumentForm_Load);
            this.gboxMaintainMetadata.ResumeLayout(false);
            this.gboxMaintainMetadata.PerformLayout();
            this.gboxSecurityStrategy.ResumeLayout(false);
            this.gboxSecurityStrategy.PerformLayout();
            this.gboxManagementProperties.ResumeLayout(false);
            this.gboxManagementProperties.PerformLayout();
            this.gboxTokenControlStrategy.ResumeLayout(false);
            this.gboxTokenControlStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMaintainMetadata;
        private System.Windows.Forms.Label lblTokenIDCaption;
        private System.Windows.Forms.Label lblTokenCaption;
        private System.Windows.Forms.Label lblRemarkCaption;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox tboxRemark;
        private System.Windows.Forms.TextBox tboxPrompt;
        private System.Windows.Forms.CheckBox cboxEnabledDateControlStrategy;
        private System.Windows.Forms.TextBox tboxToken;
        private System.Windows.Forms.ComboBox combSecurityLevel;
        private System.Windows.Forms.TextBox tboxTokenID;
        private System.Windows.Forms.LinkLabel lnkGenerateToken;
        private System.Windows.Forms.GroupBox gboxTokenControlStrategy;
        private System.Windows.Forms.DateTimePicker dtpickerEnabledDate;
        private System.Windows.Forms.Label lblEnabledDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gboxManagementProperties;
        private System.Windows.Forms.TextBox tboxModifyDate;
        private System.Windows.Forms.Label lblModifyDate;
        private System.Windows.Forms.TextBox tboxCreateDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.DateTimePicker dtpickerEnabledTime;
        private System.Windows.Forms.CheckBox cboxShowOrHideToken;
        private System.Windows.Forms.BindingSource databinding;
        private System.Windows.Forms.Label lblTokenLength;
        private System.Windows.Forms.GroupBox gboxSecurityStrategy;
        private System.Windows.Forms.Label lblSecurityKey;
        private System.Windows.Forms.ComboBox combSecurityKey;
        private System.Windows.Forms.Label lblSecurityLabel;
    }
}