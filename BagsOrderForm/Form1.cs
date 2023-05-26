//Create an order form that allows bags to be purchased. Display is a Windows dialog msg box showing the total, selection, quantity, and shipping charge. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BagsOrderForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstboxBags.ClearSelected();
            comboBox1.Text = string.Empty;

            if (rbStandard.Checked || rbThreeDay.Checked || rbOvernight.Checked)
            {
                rbStandard.Checked = false;
                rbThreeDay.Checked = false;
                rbOvernight.Checked = false;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var bags = new Dictionary<string, int>
            {
                ["Full Decrotive"] = 50,
                ["Beaded"] = 45,
                ["Pirate Design"] = 40,
                ["Fringed"] = 25,
                ["Leather"] = 80,
                ["Plain"] = 20
            };

            String sel = lstboxBags.Text;
            String quan = comboBox1.Text;

            double shipS = .05;
            double ship3 = .07;
            double shipO = .10;

            if ((!String.IsNullOrEmpty(sel)) && (!String.IsNullOrWhiteSpace(quan)) && rbStandard.Checked)
            {
                int x = Int32.Parse(comboBox1.Text);
                var s = (bags[sel] * x) * shipS; //shipping charge
                var t = (bags[sel] * x) + s; //total

                MessageBox.Show(string.Format("\nThank you for your order!\n\nDesign: " + lstboxBags.SelectedItem.ToString() + " ($" + bags[sel] + ")" + "\nQuantity: "
                    + comboBox1.Text + "\nShipping: Standard +{0:C}\n\nTotal: {1:C}", s, t));
            }
            if ((!String.IsNullOrEmpty(sel)) && (!String.IsNullOrWhiteSpace(quan)) && rbThreeDay.Checked)
            {
                int x = Int32.Parse(comboBox1.Text);
                var s = (bags[sel] * x) * ship3; //shipping charge
                var t = (bags[sel] * x) + s; //total

                MessageBox.Show(string.Format("\nThank you for your order!\n\nDesign: " + lstboxBags.SelectedItem.ToString() + " ($" + bags[sel] + ")" + "\nQuantity: "
                    + comboBox1.Text + "\nShipping: 3-Day +{0:C}\n\nTotal: {1:C}", s, t));
            }
            if ((!String.IsNullOrEmpty(sel)) && (!String.IsNullOrWhiteSpace(quan)) && rbOvernight.Checked)
            {
                int x = Int32.Parse(comboBox1.Text);
                var s = (bags[sel] * x) * shipO; //shipping charge
                var t = (bags[sel] * x) + s; //total

                MessageBox.Show(string.Format("\nThank you for your order.\n\nDesign: " + lstboxBags.SelectedItem.ToString() + " ($" + bags[sel] + ")" + "\nQuantity: "
                    + comboBox1.Text + "\nShipping: Overnight +{0:C}\n\nTotal: {1:C}", s, t));
            }
            if ((String.IsNullOrEmpty(sel)) || (String.IsNullOrWhiteSpace(quan)) || !rbStandard.Checked) {
                if ((String.IsNullOrEmpty(sel)) || (String.IsNullOrWhiteSpace(quan)) || !rbThreeDay.Checked) {
                    if ((String.IsNullOrEmpty(sel)) || (String.IsNullOrWhiteSpace(quan)) || !rbOvernight.Checked) {
                        MessageBox.Show("Bag style, quantity, and shipping required!");
                    }
                }
            }
        }
    }
}



