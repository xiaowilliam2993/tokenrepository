using System;
using System.Windows.Forms;

namespace TokenRepository.Client
{
    public partial class TokenGenerateForm : Form
    {
        public int SecurityKey { get; private set; }
        public TokenGenerateForm(int securityLevel)
        {
            InitializeComponent();

            SecurityKey = securityLevel;
        }

        private void TokenGenerateForm_Load(object sender, EventArgs e)
        {
            Text += $"(v{Application.ProductVersion})";
        }

        private void TokenGenerateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
