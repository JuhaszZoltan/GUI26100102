namespace GUI26100102
{
    public partial class FrmMain : Form
    {

        public int op1;
        public int op2;

        public FrmMain()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnMult.Click += BtnMult_Click;
            btnSub.Click += BtnSub_Click;
            btnDiv.Click += BtnDiv_Click;
        }

        private void BtnDiv_Click(object? sender, EventArgs e)
        {
            if (!IsConvertible()) return;
            if (op2 == 0)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "kísérlet történt 0-val való osztásra!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
                return;
            }
            txtResult.Text = $"{op1 / (float)op2:0.000}";
        }

        private void BtnSub_Click(object? sender, EventArgs e)
        {
            if (!IsConvertible()) return;
            txtResult.Text = $"{op1 - op2}";
        }

        private void BtnMult_Click(object? sender, EventArgs e)
        {
            if (!IsConvertible()) return;
            txtResult.Text = $"{op1 * op2}";
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!IsConvertible()) return;
            txtResult.Text = $"{op1 + op2}";
        }

        public bool IsConvertible()
        {
            if (int.TryParse(txt1stOp.Text, out op1)
            && int.TryParse(txt2nbOp.Text, out op2)) return true;
            else
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "nem megfelelő számfprmátum van az input mezőkben!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
                return false;
            }

        }
    }
}
