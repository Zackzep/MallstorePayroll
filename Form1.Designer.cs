namespace Midterm_MallStores
{
    partial class Form1
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.tbHourlyPay = new System.Windows.Forms.TextBox();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.btnHire = new System.Windows.Forms.Button();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(376, 450);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(428, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(513, 37);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(202, 22);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(513, 74);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(202, 22);
            this.tbLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(428, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(513, 113);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(202, 22);
            this.tbHours.TabIndex = 6;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(428, 116);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(43, 16);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "Hours";
            // 
            // tbHourlyPay
            // 
            this.tbHourlyPay.Location = new System.Drawing.Point(513, 154);
            this.tbHourlyPay.Name = "tbHourlyPay";
            this.tbHourlyPay.Size = new System.Drawing.Size(202, 22);
            this.tbHourlyPay.TabIndex = 8;
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Location = new System.Drawing.Point(428, 157);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(73, 16);
            this.lblHourlyPay.TabIndex = 7;
            this.lblHourlyPay.Text = "Hourly Pay";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(538, 199);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(39, 16);
            this.lblStoreID.TabIndex = 9;
            this.lblStoreID.Text = "Store";
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(513, 288);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(137, 66);
            this.btnHire.TabIndex = 11;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_AddEmployee);
            // 
            // cbStores
            // 
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(594, 196);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(121, 24);
            this.cbStores.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStores);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.lblStoreID);
            this.Controls.Add(this.tbHourlyPay);
            this.Controls.Add(this.lblHourlyPay);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbHourlyPay;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.ComboBox cbStores;
    }
}

