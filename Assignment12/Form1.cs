using System.Linq.Expressions;

namespace Assignment12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, shiftN, payN;
            Boolean checker = true;
            if (int.TryParse(textBox2.Text, out number)) { }
            else
            {
                checker = false;
                label7.Visible = true;
                label7.Text = "Enter valid type of data!";
                label6.Visible = false;
            }

            if (int.TryParse(textBox4.Text, out payN)) { }
            else
            {
                checker = false;
                label7.Visible = true;
                label7.Text = "Enter valid type of data!";
                label6.Visible = false;
            }

            if (int.TryParse(textBox3.Text, out shiftN))
            {
                if ((shiftN < 0) || (shiftN > 2))
                {
                    checker = false;
                    label7.Visible = true;
                    label7.Text = "Choose shift 1 or 2!";
                    label6.Visible = false;
                }
            }
            else
            {
                checker = false;
                label7.Visible = true;
                label7.Text = "Enter valid type of data!";
                label6.Visible = false;
            }


        ProductionWorker productionWorker = new ProductionWorker();
        productionWorker.Name = textBox1.Text;
        productionWorker.Number = number;
        productionWorker.ShiftNumber = shiftN;
        productionWorker.Pay = payN;

        if (checker)
        {
            string shift;
            shift = "";
            if (productionWorker.ShiftNumber == 1)
                {
                    shift = "day";
                }
            else if (productionWorker.ShiftNumber == 1)
                {
                    shift = "night";
                }
            label6.Text = "Production worker's name: " + productionWorker.Name + ". Production worker's number: " + productionWorker.Number + Environment.NewLine + "Production worker's shift: " + shift + ". Production worker's hourly per rate: " + productionWorker.Pay + "$" ;
            label6.Visible = true;
            label7.Visible = false;
        }
        }
    }

    class Employee
    {
        private string _name = "Ekaterina";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _number = 7;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

    }

    class ProductionWorker : Employee 
    {
        private int _shiftNumber = 1;
        public int ShiftNumber
        {
            get { return _shiftNumber; }
            set { _shiftNumber = value; }
        }

        private decimal _pay = 15;
        public decimal Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }
    }
}