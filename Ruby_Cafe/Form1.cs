using System.Windows.Forms.VisualStyles;

namespace Ruby_Cafe
{
    public partial class Form1 : Form
    {
        /*MONEY*/
        int money = 0;

        /* Food Prices*/
        int cheese = 50;
        int cupcake = 100;
        int hamburger = 150;
        int hotdog = 200 ;
        int pancake = 250;
        int pizza = 300;

       


        /* TOTAL PRiCE*/
        int totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //moneyLabelBox.Text = money.ToString() + "TL";
            moneyLabelBox.Text = $"Fiyat: ... TL";
        }

        private void cheesePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += cheese;
            cardListBox.Items.Add("Cheese");
        }

        private void cupcakePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            cardListBox.Items.Add("Cupcake");

        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            cardListBox.Items.Add("Hamburger");

        }

        private void hotdogPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            cardListBox.Items.Add("Hotdog");

        }

        private void pancakePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            cardListBox.Items.Add("Pancake");

        }

        private void pizzaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            cardListBox.Items.Add("Pizza");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= 1000)
            {
                /*Mathematical Part*/
                money +=  totalPrice;

                /* Writing Part*/
                moneyLabelBox.Text = totalPrice.ToString() + "TL";

                /* Information*/
                MessageBox.Show("Alisveris yaptiginiz icin tesekkur ederiz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
               

                string[] itemNames = { "Cheese", "Cupcake", "Hamburger", "Hotdog", "Pancake", "Pizza" };
                int [] items = { cheese, cupcake, hamburger, hotdog, pancake, pizza};
                Random rnd = new Random();
                int index = rnd.Next(items.Length);
                //string discount = items.ToString([index]);

                DialogResult result = MessageBox.Show(
                    $"Tebrikler {itemNames[index]} ürünü için %50 indirim kazandýnýz :)",
                    "Sürpriz Ýndirim",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                /*Discount Update*/
                bool discountRequested =result == DialogResult.Yes;

                //if (discountRequested == true) {
                //    MessageBox.Show("Ýndirimli Urunu Giriniz");
                //    int originalPrice = items[index];
                //    int discountedPrice = originalPrice / 2;

                //}
                do
                { 
                    int originalPrice = items[index];
                    int discountedPrice = originalPrice / 2;
                    totalPrice += discountedPrice ;
                    moneyLabelBox.Text = totalPrice.ToString() + "TL";
                    discountRequested = false;
                } while (discountRequested == true);


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            totalPrice = 0;
            moneyLabelBox.Text = "Fiyat: ... TL";
        }
    }
}
