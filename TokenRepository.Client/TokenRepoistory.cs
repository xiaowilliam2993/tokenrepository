using System;
using System.Windows.Forms;
using TokenRepository.Client.Models;
using TokenRepository.Client.Utility;

namespace TokenRepository.Client
{
    public partial class TokenRepositoryForm : Form
    {
        protected TokenBasis QueryEntry { get; set; } = new TokenBasis { 
            ID = "uuu",
            Token = "Token",

        };
        public TokenRepositoryForm()
        {
            InitializeComponent();
        }

        private void TokenRepositoryForm_Load(object sender, EventArgs e)
        {
            Text += $"(v{Application.ProductVersion})";

            databinding.DataSource = QueryEntry;

            lblTokenIDVal.DataBindings.Add(new Binding("Text", databinding, "ID", false, DataSourceUpdateMode.OnPropertyChanged));
            lblTokenVal.DataBindings.Add(new Binding("Text", databinding, "TokenSecurityDisplayValue", false, DataSourceUpdateMode.OnPropertyChanged));
            lblSecurityLevelVal.DataBindings.Add(new Binding("Text", databinding, "SecurityKey", false, DataSourceUpdateMode.OnPropertyChanged));
            lblEnabledDateControlStrategyVal.DataBindings.Add(new Binding("Text", databinding, "EnabledDateControlStrategyDisplayValue", false, DataSourceUpdateMode.OnPropertyChanged));
            lblPromptVal.DataBindings.Add(new Binding("Text", databinding, "Prompt", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TokenDocumentForm tokenDocumentForm = new TokenDocumentForm();
            tokenDocumentForm.ShowDialog();
        }

        private void lnkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TokenDocumentForm tokenDocumentForm = new TokenDocumentForm(QueryEntry);
            tokenDocumentForm.ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void lnkShowOrHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QueryEntry.SetTokenSecurityDisplayValue();
            databinding.DataSource = QueryEntry;
            databinding.ResetBindings(true);
        }

        private void tboxSearchTokenVal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Query();
            }
        }

        private void Query()
        {
            var queryID = tboxSearchTokenVal.Text;
            if (string.IsNullOrEmpty(queryID))
            {
                MessageBox.Show("Please enter search token keyword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                QueryEntry = NetworkUtil.Get<TokenBasis>($"{ConfigUtil.GetApiHost}/api/v1/tokenBasis/{queryID}/yes");
                databinding.DataSource = QueryEntry;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
