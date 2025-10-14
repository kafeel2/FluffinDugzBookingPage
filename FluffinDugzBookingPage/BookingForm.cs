using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FluffinDugzBookingPage
{
    /// <summary>
    /// Author: Kafeel Ahmed
    /// Date: 11/10/24
    /// Description: The program is a dog care booking application that allows users to select services, 
    /// calculate costs, and save bookings to a MySQL database.
    /// </summary>
    public partial class BookingForm : Form
    {
        // NOTE: Connection string has been modified for security purposes.
        // Replace 'your_database', 'your_username', and 'your_password' with your own local credentials when running the project.
        MySqlConnection connect = new MySqlConnection("server=localhost;database=your_database;uid=your_username;pwd=your_password;");


        public BookingForm()
        {
            InitializeComponent();  // Initialize form components
        }

        // This method runs when the form first loads (currently does nothing)
        private void BookingForm_Load(object sender, EventArgs e) { }

        // This method runs when the "Submit Booking" button is clicked
        private void btnSubmitBooking_Click(object sender, EventArgs e)
        {
            // Check if a service type is selected
            if (cmbServiceType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type before submitting the booking.");
                return; // Stop the method here if no service is selected
            }

            // Check if the booking date is in the past
            if (dtpBookingDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a future date for the booking.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop the method if a past date is selected
            }

            // Ensure the number of dogs is valid
            if (numDogs.Value == 0)
            {
                MessageBox.Show("Please enter a valid number of dogs.");
                return;
            }

            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Please complete all fields before submitting.");
                return;
            }

            // Get values from the form controls
            string serviceType = cmbServiceType.Text;
            string bookingDate = dtpBookingDate.Value.ToString("yyyy-MM-dd");
            string startTime = cmbStartTime.Text;
            string endTime = cmbEndTime.Text;
            int numberOfDogs = (int)numDogs.Value;
            decimal totalCost = CalculateTotalCost();

            // SQL query to insert the booking details into the database
            string query = $"INSERT INTO Bookings (ServiceType, BookingDate, StartTime, EndTime, NumberOfDogs, TotalCost) " +
                           $"VALUES ('{serviceType}', '{bookingDate}', '{startTime}', '{endTime}', {numberOfDogs}, {totalCost})";

            // Create a connection to the database and execute the query
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Method to check if all fields are filled
        private bool AreAllFieldsFilled()
        {
            return cmbServiceType.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(dtpBookingDate.Text) &&
                   !string.IsNullOrWhiteSpace(cmbStartTime.Text) &&
                   !string.IsNullOrWhiteSpace(cmbEndTime.Text) &&
                   numDogs.Value > 0;
        }

        // Method to calculate the total cost of the booking based on selected options
        private decimal CalculateTotalCost()
        {
            decimal baseCost = cmbServiceType.Text == "Daycare" ? 30 : cmbServiceType.Text == "Grooming" ? 50 : 20;
            decimal addOnCost = 0;
            if (chkNailClipping.Checked) addOnCost += 5;
            if (chkBrush.Checked) addOnCost += 5;
            if (chkWashBlowDry.Checked) addOnCost += 20;

            return (baseCost + addOnCost) * (int)numDogs.Value;
        }

        // This method runs when the "Reset" button is clicked
        private void btnRest_Click(object sender, EventArgs e)
        {
            cmbServiceType.SelectedIndex = -1;
            dtpBookingDate.Value = DateTime.Now;
            cmbStartTime.SelectedIndex = -1;
            cmbEndTime.SelectedIndex = -1;
            numDogs.Value = 1;
            chkNailClipping.Checked = false;
            chkBrush.Checked = false;
            chkWashBlowDry.Checked = false;
            lblTotalCost.Text = "Total Cost: £0.00";
            txtBookingID.Clear();  // Clear the Booking ID field


            numDogs.Value = 0; // Temporarily set to 0
        }

        // Methods below update the total cost whenever something on the form changes

        private void numDogs_ValueChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void chkNailClipping_CheckedChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void chkBrush_CheckedChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void chkWashBlowDry_CheckedChanged(object sender, EventArgs e) => UpdateTotalCost();

        // Method to update the total cost label on the form
        private void UpdateTotalCost()
        {
            lblTotalCost.Text = $"Total Cost: £{CalculateTotalCost():0.00}";
        }

        // Method to handle the "Cancel Booking" button click event
        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            // Check if Booking ID field is empty
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please enter a Booking ID to cancel.");
                return;
            }

            // Attempt to delete the booking with the provided Booking ID
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Bookings WHERE BookingID = @BookingID";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);  // Use parameterized query to avoid SQL injection
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Booking canceled successfully!");
                    else
                        MessageBox.Show("No booking found with the provided Booking ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}












