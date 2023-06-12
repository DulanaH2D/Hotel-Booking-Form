namespace Assignment_1_Que_2
{
    public partial class Form1 : Form
    {
        private int singleRooms = 10;
        private int doubleRooms = 7;
        private int familyRooms = 4;
        private int suiteRooms = 2;
        private int bookingCount = 0;

        private int singleRoomsbookingCount = 0;
        private int doubleRoomsbookingCount = 0;
        private int familyRoomsbookingCount = 0;
        private int suiteRoomsbookingCount = 0;

        private double singleRate = 5000.00;
        private double doubleRate = 7500.00;
        private double familyRate = 8000.00;
        private double suiteRate = 12500.00;

        private double subTotalBill = 0.0;
        private double totalBill = 0.0;

        public Form1()
        {
            InitializeComponent();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //Store daycount and bookingCount in the variables
            int dCount = int.Parse(dayCount.Text);
            bookingCount = int.Parse(roomCount.Text);



            //Calculate subTotalBill
            switch (roomType.Text)
            {
                case "Single":
                    subTotalBill = singleRate * dCount * bookingCount;
                    break;

                case "Double":
                    subTotalBill = doubleRate * dCount * bookingCount;

                    if (dCount > 5)
                    {
                        subTotalBill -= subTotalBill * 0.05;
                    }
                    break;

                case "Family":
                    subTotalBill = familyRate * dCount * bookingCount;
                    break;

                case "Suite":
                    subTotalBill = suiteRate * dCount * bookingCount;
                    if (dCount > 5)
                    {
                        subTotalBill -= subTotalBill * 0.12;
                    }
                    break;

                default:
                    MessageBox.Show("Please select a valid room type.");
                    break;
            }



            //Booking rooms and checking availability
            if (anotherBooking.Text == "Yes")
            {
                calcBtn.Enabled = true;
            }
            else if (anotherBooking.Text == "No")
            {
                //Clear text fields and combo box
                nameE.Clear();
                addressE.Clear();
                calcBtn.Enabled = false;
            }

            //For Single room
            if (roomType.Text == "Single")
            {
                singleRoomsbookingCount += bookingCount;
                if (singleRoomsbookingCount > singleRooms)
                {
                    MessageBox.Show("Sorry, no more single rooms available.", "Rooms Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    singleRoomsbookingCount -= bookingCount;
                }

                else
                {
                    calTotal();
                }
            }


            //For Double room
            if (roomType.Text == "Double")
            {
                doubleRoomsbookingCount += bookingCount;
                if (doubleRoomsbookingCount > doubleRooms)
                {
                    MessageBox.Show("Sorry, no more double rooms available.", "Rooms Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    doubleRoomsbookingCount -= bookingCount;

                }

                else
                {
                    calTotal();
                }
            }


            //For Family room
            if (roomType.Text == "Family")
            {
                familyRoomsbookingCount += bookingCount;
                if (familyRoomsbookingCount > familyRooms)
                {
                    MessageBox.Show("Sorry, no more family rooms available.", "Rooms Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    familyRoomsbookingCount -= bookingCount;
                }

                else
                {
                    calTotal();
                }
            }


            //For Suite room
            if (roomType.Text == "Suite")
            {
                suiteRoomsbookingCount += bookingCount;
                if (suiteRoomsbookingCount > suiteRooms)
                {
                    MessageBox.Show("Sorry, no more suite rooms available.", "Rooms Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    suiteRoomsbookingCount -= bookingCount;
                }
                else
                {
                    calTotal();
                }
            }

            clearFieldAndComboBox();

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            subTotalBill = 0;
            totalBill = 0;

            //Clear Button
            nameE.Clear();
            addressE.Clear();
            totalPrice.Clear();
            clearFieldAndComboBox();

            //Enable calculate price button
            calcBtn.Enabled = true;

        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            if (anotherBooking.Text == "Yes")
            {
                MessageBox.Show("You have select \"Do you another booking field\" as \"YES\". If you want to exit please change that filed as a \"NO\" !");
            }
            else
            {
                Application.Exit();
            }

        }

        private void calTotal()
        {
            //Calculate and Print total bill in totalPrice textField
            totalBill += subTotalBill;
            totalPrice.Text = totalBill.ToString();
        }

        private void clearFieldAndComboBox()
        {
            //Clear text fields and combo box
            roomCount.Clear();
            dayCount.Clear();
            roomType.Text = " ";
            anotherBooking.Text = " ";
        }
    }
}