namespace BagsOrderForm
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
            this.lstboxBags = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblBagsOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOvernight = new System.Windows.Forms.RadioButton();
            this.rbThreeDay = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxBags
            // 
            this.lstboxBags.BackColor = System.Drawing.Color.LightGray;
            this.lstboxBags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxBags.FormattingEnabled = true;
            this.lstboxBags.ItemHeight = 16;
            this.lstboxBags.Items.AddRange(new object[] {
            "Full Decrotive",
            "Beaded",
            "Pirate Design",
            "Fringed",
            "Leather",
            "Plain"});
            this.lstboxBags.Location = new System.Drawing.Point(26, 36);
            this.lstboxBags.Name = "lstboxBags";
            this.lstboxBags.Size = new System.Drawing.Size(179, 52);
            this.lstboxBags.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(161, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(26, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Blue;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(130, 214);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 36);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(170, 97);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(26, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Qty.";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(23, 97);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(48, 13);
            this.lblShipping.TabIndex = 7;
            this.lblShipping.Text = "Shipping";
            // 
            // lblBagsOrder
            // 
            this.lblBagsOrder.AutoSize = true;
            this.lblBagsOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBagsOrder.Location = new System.Drawing.Point(43, 9);
            this.lblBagsOrder.Name = "lblBagsOrder";
            this.lblBagsOrder.Size = new System.Drawing.Size(146, 20);
            this.lblBagsOrder.TabIndex = 8;
            this.lblBagsOrder.Text = "Bags Order Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOvernight);
            this.groupBox1.Controls.Add(this.rbThreeDay);
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Location = new System.Drawing.Point(26, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbOvernight
            // 
            this.rbOvernight.AutoSize = true;
            this.rbOvernight.Location = new System.Drawing.Point(6, 54);
            this.rbOvernight.Name = "rbOvernight";
            this.rbOvernight.Size = new System.Drawing.Size(71, 17);
            this.rbOvernight.TabIndex = 2;
            this.rbOvernight.TabStop = true;
            this.rbOvernight.Text = "Overnight";
            this.rbOvernight.UseVisualStyleBackColor = true;
            // 
            // rbThreeDay
            // 
            this.rbThreeDay.AutoSize = true;
            this.rbThreeDay.Location = new System.Drawing.Point(7, 31);
            this.rbThreeDay.Name = "rbThreeDay";
            this.rbThreeDay.Size = new System.Drawing.Size(53, 17);
            this.rbThreeDay.TabIndex = 1;
            this.rbThreeDay.TabStop = true;
            this.rbThreeDay.Text = "3-Day";
            this.rbThreeDay.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(6, 8);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(231, 277);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBagsOrder);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstboxBags);
            this.Name = "Form1";
            this.Text = "BagsOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxBags;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblBagsOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOvernight;
        private System.Windows.Forms.RadioButton rbThreeDay;
        private System.Windows.Forms.RadioButton rbStandard;
    }
}

