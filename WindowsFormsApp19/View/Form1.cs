using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp19.Model;
using WindowsFormsApp19.View;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form,IMainView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public EventHandler<EventArgs> IndexChanged { get; set; }
        public EventHandler<EventArgs> CheckedChanged { get; set; }
        public EventHandler<EventArgs> AznCheckedChanged { get; set; }
        public EventHandler<EventArgs> HDCheckedChanged { get; set; }
        public EventHandler<EventArgs> FPCheckedChanged { get; set; }
        public EventHandler<EventArgs> CCCheckedChanged { get; set; }
        public EventHandler<EventArgs> ICCheckedChanged { get; set; }
        public EventHandler<EventArgs> CalculateClick { get; set; }
        public EventHandler<EventArgs> LoadClick { get; set; }
        public List<Payment> Payments
        {
            set
            {
                PaymentH.DataSource = null;
                PaymentH.DataSource = value;

            }
        }
        public string PriceText { get => Price.Text; set => Price.Text = value; }
        public List<Petrol> Petrols
        {
            set
            {
                OilCombo.DataSource = null;
                OilCombo.DataSource = value;

            }
        }
        public bool isLiter { get => LiterBtn.Checked; set => LiterBtn.Checked = value; }
        public string MoneyText { get => MoneyBox.Text; set => MoneyBox.Text = value; }
        public string LiterText { get => LiterBox.Text; set => LiterBox.Text = value; }
        public string TotalText { get => Total.Text; set => Total.Text = value; }
        public string Total2Text { get => Total2.Text; set => Total2.Text = value; }
        public string CCText { get => CCBox.Text; set => CCBox.Text = value; }
        public string FPText { get => FPBox.Text; set => FPBox.Text = value; }
        public string ICText { get => İCBox.Text; set => İCBox.Text = value; }
        public string HDText { get => HDBox.Text; set => HDBox.Text = value; }
        public string CCPrText { get => ccp.Text; }
        public string FPPrText { get => fpp.Text; }
        public string İCPrText { get => icp.Text; }
        public string HDPrText { get => hdpr.Text; }
        public bool isActiveAz { get => MoneyBox.Enabled; set => MoneyBox.Enabled = value; }
        public bool isActiveLt { get => LiterBox.Enabled; set => LiterBox.Enabled = value; }
        public bool isHDActive { get => HDBox.Enabled; set => HDBox.Enabled = value; }
        public bool isFPActive { get => FPBox.Enabled; set => FPBox.Enabled = value; }
        public bool isCCActive { get => CCBox.Enabled; set => CCBox.Enabled = value; }
        public bool isICActive { get => İCBox.Enabled; set => İCBox.Enabled = value; }

        private void OilCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChanged.Invoke(sender, e);
        }

        private void LiterBtn_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged.Invoke(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AznCheckedChanged.Invoke(sender, e);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            CalculateClick.Invoke(sender, e);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            LoadClick.Invoke(sender, e);
        }

        private void HD_CheckedChanged(object sender, EventArgs e)
        {
            HDCheckedChanged.Invoke(sender, e);
        }

        private void FP_CheckedChanged(object sender, EventArgs e)
        {
            FPCheckedChanged.Invoke(sender, e);
        }

        private void CC_CheckedChanged(object sender, EventArgs e)
        {
            CCCheckedChanged.Invoke(sender, e);
        }

        private void İC_CheckedChanged(object sender, EventArgs e)
        {
            ICCheckedChanged.Invoke(sender, e);
        }
    }
}
