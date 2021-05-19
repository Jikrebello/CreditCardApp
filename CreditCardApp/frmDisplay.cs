using System;
using System.Windows.Forms;
using System.IO;

namespace CreditCardApp
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }
        
        // Fields
        private string applicationNumber;
        private string salary;
        private string rent;
        private string yearsEmployed;
        private string yearsResiding;

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            TxtProcessed.Text = "";
            string contents = "";

            TxtProcessed.Text = " Credit Card Application Status Report." + Environment.NewLine + Environment.NewLine;

            string path = Application.StartupPath;
            string fullPath = path + @"\Applications.txt";

            StreamReader reader = new StreamReader(fullPath);

            while (!reader.EndOfStream)
            {
                ReadCreditFile(reader);

                string creditStatus = CreditCardStatus();

                contents += " Application #: " + applicationNumber +
                            "\tMonthly Salary: " + double.Parse(salary).ToString("c") + 
                            "\tMonthly Rent: " + double.Parse(rent).ToString("c") + 
                            "\tYears Employed: " + yearsEmployed + 
                            "\t\tYears at Current Address: " + yearsResiding + 
                            "\tApplication Status: " + creditStatus + " " +
                            Environment.NewLine + 
                            Environment.NewLine;
            }

            reader.Close();

            TxtProcessed.Text += contents;
        }

        private void ReadCreditFile(StreamReader _r)
        {
            applicationNumber = _r.ReadLine();
            salary = _r.ReadLine();
            rent = _r.ReadLine();
            yearsEmployed = _r.ReadLine();
            yearsResiding = _r.ReadLine();
        }

        private string CreditCardStatus()
        {
            string status;
    
            // have a salary of over $25,000 per year,
            if (double.Parse(salary) >= 25000)
                status = "Approved.";
            // have an annual salary of over $20,000 and pay rent of less than one quarter of a month's salary
            else if (double.Parse(salary) >= 20000 && double.Parse(rent) <= double.Parse(salary) / 4.8)
                status = "Approved.";
            // have an annual salary of over $15,000 and be living at the same address for more than 5 years
            else if (double.Parse(salary) >= 15000 && int.Parse(yearsResiding) >= 5)
                status = "Approved.";
            // have an annual salary of at least $10,000 and be living at the same address for at least 5 years and be employed at the same job for at least 3 years
            else if (double.Parse(salary) >= 10000 && int.Parse(yearsResiding) >= 5 && int.Parse(yearsEmployed) >= 3)
                status = "Approved.";
            // All other applications are rejected.
            else
                status = "Rejected.";

            return status;
        }

    }
}
