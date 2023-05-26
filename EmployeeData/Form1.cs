/* program should accept input data such as: employee name, number, pay rate and number of hours worked.
 * calculate the values and allow the user to save or load the file.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeeData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
            txtTotal.Visible = false;
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog fr = new OpenFileDialog();

            fr.Title = "Open File";
            fr.Filter = "txt files" + " (*.txt)|*.txt";
            fr.InitialDirectory = @"c:\Desktop";
            fr.FilterIndex = 2;
            fr.RestoreDirectory = true;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = System.IO.File.ReadAllText(fr.FileName);
                    string[] parts = file.Split(',');
                    if (parts.Length != 5)
                    {
                        MessageBox.Show("Invalid file format.");
                        return;
                    }

                    txtName.Text = parts[0];
                    txtNumber.Text = parts[1];
                    txtPay.Text = parts[2];
                    txtHours.Text = parts[3];
                    txtTotal.Text = parts[4];

                    txtName.Enabled = false;
                    txtTotal.Enabled = false;
                    txtNumber.Enabled = false;
                    txtPay.Enabled = false;
                    txtHours.Enabled = false;

                    txtNumber.Visible = true;
                    txtPay.Visible = true;
                    txtHours.Visible = true;
                    lblTotal.Visible = true;
                    txtTotal.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk." + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            Stream myStream;
            SaveFileDialog fs = new SaveFileDialog();
            fs.Filter = "txt files" + " (*.txt)|*.txt";
            fs.FilterIndex = 2;
            fs.RestoreDirectory = true;
            if (fs.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = fs.OpenFile()) != null)
                {
                    using (StreamWriter writeToFile = new StreamWriter(myStream))
                    {
                        int hours = Convert.ToInt32(txtHours.Text);
                        double pay = Convert.ToDouble(txtPay.Text), total = 0;

                        writeToFile.Write(txtName.Text);
                        writeToFile.Write(",");
                        writeToFile.Write(txtNumber.Text);
                        writeToFile.Write(",");
                        writeToFile.Write(txtPay.Text);
                        writeToFile.Write(",");
                        writeToFile.Write(txtHours.Text);

                        int hr = 40;
                        double time = 1.5;

                        if (hours > hr)
                        {
                            pay = (pay * hr) + ((hours - hr) * (pay * time));
                        }  
                        else
                        {
                            pay = pay * hours;
                        }

                        total += pay;

                        writeToFile.Write(",");
                        writeToFile.Write("$" + total.ToString());

                        MessageBox.Show("File saved!");
                    }
                    myStream.Close();
                }
            }
        }

       
    }
}

       