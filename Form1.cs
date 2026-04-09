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
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                listOrder.Items.Add("햄버거 5,000원");
                check = true;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                listOrder.Items.Add("불고기버거 4,000원");
                check = true;
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                listOrder.Items.Add("치킨버거 3,000원");
                check = true;
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                listOrder.Items.Add("감자튀김 3,500원");
                check = true;
            }
            if (chkCoke.Checked)
            {
                totalCost += 2500;
                listOrder.Items.Add("콜라 2,500원");
                check = true;
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                listOrder.Items.Add("치즈 1,500원");
                check = true;
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                listOrder.Items.Add("소스 500원");
                check = true;
            }

            if (!check)
            {
                lblWarning.Visible = true;
                check = true;
                return;
            }

            lblWarning.Visible = false;
            lblTotalcost.Text = $"총 금액 : {totalCost:N0}원"
            ;
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

            listOrder.Items.Clear();
            lblTotalcost.Text = "총 금액 : 0원";
        }
    }
}
