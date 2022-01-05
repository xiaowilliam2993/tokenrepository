using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TokenRepository.Client.Models;
using TokenRepository.Client.Models.Type;
using TokenRepository.Client.Utility;
using TokenRepository.NetworkRequest.Core;
using TokenRepository.NetworkRequest.Models;

namespace TokenRepository.Client
{
    public partial class TokenDocumentForm : Form
    {
        private int _formCloseState;
        public TokenBasis DataSource { get; private set; } = new TokenBasis();
        public TokenDocumentForm()
        {
            InitializeComponent();

            DataSource = new TokenBasis
            {
                DocumentStatus = DocumentStatus.Create
            };
        }
        public TokenDocumentForm(TokenBasis queryEntry)
        {
            InitializeComponent();

            DataSource.DocumentStatus = DocumentStatus.Edit;
            DataSource = queryEntry;
        }

        private void TokenDocumentForm_Load(object sender, EventArgs e)
        {
            Text += $"(v{Application.ProductVersion})";

            DataSource.SecurityLevels = GetSecurityLevels();
            databinding.DataSource = DataSource;

            //combSecurityLevel.DataBindings.Add("SelectedIndex", databinding, "SecurityLevels", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void lnkGenerateToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TokenGenerateForm tokenGenerateForm = new TokenGenerateForm(1);
            tokenGenerateForm.ShowDialog();
        }

        private void cboxEnabledDateControlStrategy_CheckedChanged(object sender, EventArgs e)
        {
            dtpickerEnabledDate.Enabled = dtpickerEnabledTime.Enabled = cboxEnabledDateControlStrategy.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (CloseWindow())
            {
                _formCloseState = 1;
                Close();
            }
        }

        private void TokenDocumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel && _formCloseState == 0)
            {
                if (!CloseWindow())
                {
                    e.Cancel = true;
                }
            }
        }

        private bool CloseWindow()
        {
            bool cancel = false;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the current operation？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                cancel = true; 
            }
            return cancel;
        }

        private IEnumerable<string> GetSecurityLevels()
        {
            IEnumerable<string> securityLevels = Enumerable.Empty<string>();
            var apiResponse = NetworkRequestWorker.Get($"{ConfigUtil.GetApiHost}/api/v1/securityLevelBasis/getLevel");
            if (apiResponse.IsSuccessStatusCode)
            {
                var apiContext = apiResponse.GetResultAsGeneric<ApiContext>();
                if (apiContext.Status == ReturnStatus.Success)
                {
                    var data = (JArray)apiContext.Data;
                    if (data.Count > 0)
                    {
                        securityLevels = JsonConvert.DeserializeObject<IEnumerable<string>>(data.ToString());
                    }
                }
                else
                {

                }
            }
            else
            {

            }
            return securityLevels;
        }
    }
}
