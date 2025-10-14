namespace FluffinDugzBookingPage
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.chkNailClipping = new System.Windows.Forms.CheckBox();
            this.chkBrush = new System.Windows.Forms.CheckBox();
            this.chkWashBlowDry = new System.Windows.Forms.CheckBox();
            this.numDogs = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnSubmitBooking = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book a Service for Your Dog";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Dog Walking",
            "Grooming",
            "Daycare",
            "Swim Session",
            "Overnight Stay"});
            this.cmbServiceType.Location = new System.Drawing.Point(73, 87);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(121, 21);
            this.cmbServiceType.TabIndex = 1;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(73, 129);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingDate.TabIndex = 2;
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Items.AddRange(new object[] {
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM"});
            this.cmbStartTime.Location = new System.Drawing.Point(187, 174);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(121, 21);
            this.cmbStartTime.TabIndex = 3;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Items.AddRange(new object[] {
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM"});
            this.cmbEndTime.Location = new System.Drawing.Point(187, 224);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(121, 21);
            this.cmbEndTime.TabIndex = 4;
            // 
            // chkNailClipping
            // 
            this.chkNailClipping.AutoSize = true;
            this.chkNailClipping.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNailClipping.Location = new System.Drawing.Point(73, 285);
            this.chkNailClipping.Name = "chkNailClipping";
            this.chkNailClipping.Size = new System.Drawing.Size(171, 23);
            this.chkNailClipping.TabIndex = 5;
            this.chkNailClipping.Text = "Nail Clipping (£5)";
            this.chkNailClipping.UseVisualStyleBackColor = true;
            this.chkNailClipping.Click += new System.EventHandler(this.chkNailClipping_CheckedChanged);
            // 
            // chkBrush
            // 
            this.chkBrush.AutoSize = true;
            this.chkBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrush.Location = new System.Drawing.Point(73, 314);
            this.chkBrush.Name = "chkBrush";
            this.chkBrush.Size = new System.Drawing.Size(112, 24);
            this.chkBrush.TabIndex = 6;
            this.chkBrush.Text = "Brush (£5)";
            this.chkBrush.UseVisualStyleBackColor = true;
            this.chkBrush.Click += new System.EventHandler(this.chkBrush_CheckedChanged);
            // 
            // chkWashBlowDry
            // 
            this.chkWashBlowDry.AutoSize = true;
            this.chkWashBlowDry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWashBlowDry.Location = new System.Drawing.Point(73, 344);
            this.chkWashBlowDry.Name = "chkWashBlowDry";
            this.chkWashBlowDry.Size = new System.Drawing.Size(230, 24);
            this.chkWashBlowDry.TabIndex = 7;
            this.chkWashBlowDry.Text = "Wash and Blow Dry (£20)";
            this.chkWashBlowDry.UseVisualStyleBackColor = true;
            this.chkWashBlowDry.Click += new System.EventHandler(this.chkWashBlowDry_CheckedChanged);
            // 
            // numDogs
            // 
            this.numDogs.Location = new System.Drawing.Point(74, 387);
            this.numDogs.Name = "numDogs";
            this.numDogs.Size = new System.Drawing.Size(120, 20);
            this.numDogs.TabIndex = 8;
            this.numDogs.Click += new System.EventHandler(this.numDogs_ValueChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(71, 426);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(142, 19);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "Total Cost: £0.00";
            // 
            // btnSubmitBooking
            // 
            this.btnSubmitBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmitBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmitBooking.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitBooking.Location = new System.Drawing.Point(642, 286);
            this.btnSubmitBooking.Name = "btnSubmitBooking";
            this.btnSubmitBooking.Size = new System.Drawing.Size(101, 39);
            this.btnSubmitBooking.TabIndex = 10;
            this.btnSubmitBooking.Text = "Submit Booking";
            this.btnSubmitBooking.UseVisualStyleBackColor = false;
            this.btnSubmitBooking.Click += new System.EventHandler(this.btnSubmitBooking_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRest.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRest.Location = new System.Drawing.Point(495, 286);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(103, 40);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "End Time";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(623, 386);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Booking ID";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelBooking.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelBooking.Location = new System.Drawing.Point(398, 373);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(103, 40);
            this.btnCancelBooking.TabIndex = 17;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnSubmitBooking);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.numDogs);
            this.Controls.Add(this.chkWashBlowDry);
            this.Controls.Add(this.chkBrush);
            this.Controls.Add(this.chkNailClipping);
            this.Controls.Add(this.cmbEndTime);
            this.Controls.Add(this.cmbStartTime);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.CheckBox chkNailClipping;
        private System.Windows.Forms.CheckBox chkBrush;
        private System.Windows.Forms.CheckBox chkWashBlowDry;
        private System.Windows.Forms.NumericUpDown numDogs;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnSubmitBooking;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelBooking;
    }
}

