using System;
using System.Windows.Forms;

namespace TP_MOD_03_1302210024
{
    public partial class Form1 : Form
    {
        private TextBox txtInput;
        private Button btnSubmit;
        private Label lblOutput;

        public Form1()
        {
            InitializeComponent();
            txtInput = new TextBox();
            btnSubmit = new Button();
            lblOutput = new Label();
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            txtInput.Location = new System.Drawing.Point(50, 50);
            txtInput.Size = new System.Drawing.Size(200, 20);

            btnSubmit.Location = new System.Drawing.Point(100, 100);
            btnSubmit.Size = new System.Drawing.Size(100, 30);
            btnSubmit.Text = "Submit";
            btnSubmit.Click += new EventHandler(btnSubmit_Click);

            lblOutput.Location = new System.Drawing.Point(50, 150);
            lblOutput.Size = new System.Drawing.Size(200, 20);

            this.Controls.Add(txtInput);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(lblOutput);

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }
    }
}