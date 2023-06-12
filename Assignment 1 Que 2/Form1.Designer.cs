namespace Assignment_1_Que_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            roomType = new ComboBox();
            nameE = new TextBox();
            addressE = new TextBox();
            dayCount = new TextBox();
            calcBtn = new Button();
            clrBtn = new Button();
            extBtn = new Button();
            label7 = new Label();
            totalPrice = new TextBox();
            label8 = new Label();
            anotherBooking = new ComboBox();
            roomCount = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(209, 23);
            label1.Name = "label1";
            label1.Size = new Size(219, 33);
            label1.TabIndex = 0;
            label1.Text = "Booking Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 196);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 2;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 147);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 96);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(49, 292);
            label6.Name = "label6";
            label6.Size = new Size(179, 23);
            label6.TabIndex = 5;
            label6.Text = "How Many Days";
            // 
            // roomType
            // 
            roomType.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            roomType.FormattingEnabled = true;
            roomType.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            roomType.Location = new Point(266, 188);
            roomType.Name = "roomType";
            roomType.Size = new Size(183, 31);
            roomType.TabIndex = 6;
            // 
            // nameE
            // 
            nameE.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nameE.Location = new Point(266, 88);
            nameE.Name = "nameE";
            nameE.Size = new Size(162, 31);
            nameE.TabIndex = 7;
            // 
            // addressE
            // 
            addressE.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addressE.Location = new Point(266, 139);
            addressE.Name = "addressE";
            addressE.Size = new Size(287, 31);
            addressE.TabIndex = 8;
            // 
            // dayCount
            // 
            dayCount.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dayCount.Location = new Point(266, 284);
            dayCount.Name = "dayCount";
            dayCount.Size = new Size(49, 31);
            dayCount.TabIndex = 10;
            // 
            // calcBtn
            // 
            calcBtn.BackColor = SystemColors.MenuBar;
            calcBtn.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calcBtn.ForeColor = Color.Olive;
            calcBtn.Location = new Point(359, 387);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(284, 35);
            calcBtn.TabIndex = 11;
            calcBtn.Text = "Calculate the Price";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = SystemColors.MenuBar;
            clrBtn.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clrBtn.ForeColor = SystemColors.ControlDarkDark;
            clrBtn.Location = new Point(466, 507);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(87, 35);
            clrBtn.TabIndex = 12;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // extBtn
            // 
            extBtn.BackColor = SystemColors.MenuBar;
            extBtn.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            extBtn.ForeColor = Color.Firebrick;
            extBtn.Location = new Point(568, 507);
            extBtn.Name = "extBtn";
            extBtn.Size = new Size(75, 35);
            extBtn.TabIndex = 13;
            extBtn.Text = "Exit";
            extBtn.UseVisualStyleBackColor = false;
            extBtn.Click += extBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(49, 447);
            label7.Name = "label7";
            label7.Size = new Size(153, 23);
            label7.TabIndex = 14;
            label7.Text = "Total Price";
            label7.Click += label7_Click;
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalPrice.Location = new Point(266, 444);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(162, 31);
            totalPrice.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(49, 331);
            label8.Name = "label8";
            label8.Size = new Size(504, 23);
            label8.TabIndex = 16;
            label8.Text = "Do you want to do an another booking? ";
            // 
            // anotherBooking
            // 
            anotherBooking.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            anotherBooking.FormattingEnabled = true;
            anotherBooking.Items.AddRange(new object[] { "Yes", "No" });
            anotherBooking.Location = new Point(568, 323);
            anotherBooking.Name = "anotherBooking";
            anotherBooking.Size = new Size(69, 31);
            anotherBooking.TabIndex = 17;
            // 
            // roomCount
            // 
            roomCount.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            roomCount.Location = new Point(266, 238);
            roomCount.Name = "roomCount";
            roomCount.Size = new Size(49, 31);
            roomCount.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 246);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 19;
            label2.Text = "Room Count";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 564);
            Controls.Add(roomCount);
            Controls.Add(label2);
            Controls.Add(anotherBooking);
            Controls.Add(label8);
            Controls.Add(totalPrice);
            Controls.Add(label7);
            Controls.Add(extBtn);
            Controls.Add(clrBtn);
            Controls.Add(calcBtn);
            Controls.Add(dayCount);
            Controls.Add(addressE);
            Controls.Add(nameE);
            Controls.Add(roomType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = " Hotel Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox roomType;
        private TextBox nameE;
        private TextBox addressE;
        private TextBox dayCount;
        private Button calcBtn;
        private Button clrBtn;
        private Button extBtn;
        private Label label7;
        private TextBox totalPrice;
        private Label label8;
        private ComboBox anotherBooking;
        private TextBox roomCount;
        private Label label2;
    }
}