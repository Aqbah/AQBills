using System.Windows.Forms;

namespace AQBills
{

    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            TotalAmount.Text = "0";
            TotalItems.Text = "";
            string Nachos = checkNachos.Text;
            string French = checkFrench.Text;
            string Loaded = checkLoaded.Text;
            string Club = checkClub.Text;
            string Wrap = checkWrap.Text;
            string Beef = checkBeef.Text;
            string Special = checkSpecial.Text;
            string Pepsi = CheckPepsi.Text;
            string Sprite = CheckSprite.Text;
            string Fanta = CheckFanta.Text;
            string Dew = CheckDew.Text;
            string Tea = CheckTea.Text;
            string Coffee = CheckCoffee.Text;
            string Redbull = CheckRedbull.Text;         
            string title = "Receipt";
            BillLbl.Visible = true;
            ItemsList.Visible = true;
            TotalItems.Visible = true;
            TotalAmountLbl.Visible = true;
            TotalAmount.Visible = true;

        List<string> itemName = new List<string>();
            List<string> itemCost = new List<string>();

            //Using List and Loop
            if (checkNachos.Checked)
            {
                itemName.Add(Nachos);
                itemCost.Add(PrcNachos.Text);
            }

            if (checkFrench.Checked)
            {
                itemName.Add(French);
                itemCost.Add(PrcFrench.Text);
            }

            if (checkLoaded.Checked)
            {
                itemName.Add(Loaded);
                itemCost.Add(PrcLoaded.Text);
            }

            if (checkClub.Checked)
            {
                itemName.Add(Club);
                itemCost.Add(PrcClub.Text);
            }

            if (checkWrap.Checked)
            {
                itemName.Add(Wrap);
                itemCost.Add(PrcWrap.Text);
            }

            if (checkBeef.Checked)
            {
                itemName.Add(Beef);
                itemCost.Add(PrcBeef.Text);
            }

            if (checkSpecial.Checked)
            {
                itemName.Add(Special);
                itemCost.Add(PrcSpecial.Text);
            }

            if (CheckPepsi.Checked)
            {
                itemName.Add(Pepsi);
                itemCost.Add(PrcPepsi.Text);
            }

            if (CheckSprite.Checked)
            {
                itemName.Add(Sprite);
                itemCost.Add(PrcSprite.Text);
            }

            if (CheckFanta.Checked)
            {
                itemName.Add(Fanta);
                itemCost.Add(PrcFanta.Text);
            }

            if (CheckDew.Checked)
            {
                itemName.Add(Dew);
                itemCost.Add(PrcDew.Text);
            }

            if (CheckTea.Checked)
            {
                itemName.Add(Tea);
                itemCost.Add(PrcTea.Text);
            }

            if (CheckCoffee.Checked)
            {
                itemName.Add(Coffee);
                itemCost.Add(PrcCoffee.Text);
            }

            if (CheckRedbull.Checked)
            {
                itemName.Add(Redbull);
                itemCost.Add(PrcRedbull.Text);
            }

            for (int i = 0; i < itemName.Count; i++)
            {
                TotalItems.Text = TotalItems.Text + "\n" + itemName[i];
            }

            for (int i = 0; i < itemCost.Count; i++)
            {
                TotalAmount.Text = Convert.ToString(Convert.ToInt32(TotalAmount.Text) + Convert.ToInt32(itemCost[i]));
            }

            string message = "Thankyou for ordering from AQ's Cafe! Total amount payable is RS. " + TotalAmount.Text;
            MessageBox.Show(message, title,MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BillInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }

        private void TotalItems_Click(object sender, EventArgs e)
        {

        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}