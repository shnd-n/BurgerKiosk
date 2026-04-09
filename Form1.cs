using System.Reflection.Emit;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        bool check = false;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = title;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                lblWarning.Visible = true;
                check = true;
                return;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCoke.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lblWarning.Visible = false;
            check = false;
            totalCost = 0;
            listOrder.Items.Clear();
            lblTotalcost.Text = "총 금액 : 0원";
        }

        private void btnOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOrder.PerformClick();
            }
        }

        private void btnInit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInit.PerformClick();
            }
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (listOrder.Items.Contains("햄버거 5,000원"))
            {
                listOrder.Items.Remove("햄버거 5,000원");
                totalCost -= 5000;
                check = false;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                totalCost += 5000;
                listOrder.Items.Add("햄버거 5,000원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (listOrder.Items.Contains("불고기버거 4,000원"))
            {
                listOrder.Items.Remove("불고기버거 4,000원");
                totalCost -= 4000;
                check = false;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                totalCost += 4000;
                listOrder.Items.Add("불고기버거 4,000원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (listOrder.Items.Contains("치킨버거 3,000원"))
            {
                listOrder.Items.Remove("치킨버거 3,000원");
                totalCost -= 3000;
                check = false;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                totalCost += 3000;
                listOrder.Items.Add("치킨버거 3,000원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                listOrder.Items.Add("감자튀김 3,500원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                listOrder.Items.Remove("감자튀김 3,500원");
                totalCost -= 3500;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void chkCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoke.Checked)
            {
                totalCost += 2500;
                listOrder.Items.Add("콜라 2,500원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                listOrder.Items.Remove("콜라 2,500원");
                totalCost -= 2500;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                listOrder.Items.Add("치즈 1,500원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                listOrder.Items.Remove("치즈 1,500원");
                totalCost -= 1500;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSauce.Checked)
            {
                totalCost += 500;
                listOrder.Items.Add("소스 500원");
                check = true;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                listOrder.Items.Remove("소스 500원");
                totalCost -= 500;
                lblTotalcost.Text = $"총 금액 : {totalCost:N0}원";
            }
        }
    }
}
