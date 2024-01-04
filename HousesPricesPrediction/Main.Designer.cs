namespace HousesPricesPrediction
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            groupBox1 = new GroupBox();
            comboBoxCommunityType = new ComboBox();
            numericUpDownBathRooms = new NumericUpDown();
            label6 = new Label();
            numericUpDownBedRoms = new NumericUpDown();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxYearBuild = new TextBox();
            textBoxArea = new TextBox();
            label10 = new Label();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonStartPredict = new Button();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label1PriceResult = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBathRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBedRoms).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCommunityType);
            groupBox1.Controls.Add(numericUpDownBathRooms);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownBedRoms);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxYearBuild);
            groupBox1.Controls.Add(textBoxArea);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(16, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // comboBoxCommunityType
            // 
            comboBoxCommunityType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCommunityType.FormattingEnabled = true;
            comboBoxCommunityType.Items.AddRange(new object[] { "Rural", "Urban", "SubUrban" });
            comboBoxCommunityType.Location = new Point(176, 180);
            comboBoxCommunityType.Name = "comboBoxCommunityType";
            comboBoxCommunityType.Size = new Size(213, 29);
            comboBoxCommunityType.TabIndex = 3;
            // 
            // numericUpDownBathRooms
            // 
            numericUpDownBathRooms.Location = new Point(176, 129);
            numericUpDownBathRooms.Name = "numericUpDownBathRooms";
            numericUpDownBathRooms.Size = new Size(211, 29);
            numericUpDownBathRooms.TabIndex = 2;
            numericUpDownBathRooms.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(393, 132);
            label6.Name = "label6";
            label6.Size = new Size(34, 21);
            label6.TabIndex = 0;
            label6.Text = "No.";
            // 
            // numericUpDownBedRoms
            // 
            numericUpDownBedRoms.Location = new Point(176, 78);
            numericUpDownBedRoms.Name = "numericUpDownBedRoms";
            numericUpDownBedRoms.Size = new Size(211, 29);
            numericUpDownBedRoms.TabIndex = 2;
            numericUpDownBedRoms.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 183);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 0;
            label7.Text = "Community";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(393, 81);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 0;
            label4.Text = "No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 132);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 0;
            label5.Text = "Bath Rooms";
            // 
            // textBoxYearBuild
            // 
            textBoxYearBuild.Location = new Point(176, 229);
            textBoxYearBuild.Name = "textBoxYearBuild";
            textBoxYearBuild.Size = new Size(211, 29);
            textBoxYearBuild.TabIndex = 1;
            textBoxYearBuild.Text = "2024";
            textBoxYearBuild.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(176, 27);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(211, 29);
            textBoxArea.TabIndex = 1;
            textBoxArea.Text = "150";
            textBoxArea.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(393, 232);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 0;
            label10.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 81);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 0;
            label3.Text = "Bed Rooms";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 232);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 0;
            label9.Text = "Year Built";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(393, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 0;
            label2.Text = "m^2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "Area";
            // 
            // buttonStartPredict
            // 
            buttonStartPredict.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartPredict.Location = new Point(18, 432);
            buttonStartPredict.Name = "buttonStartPredict";
            buttonStartPredict.Size = new Size(468, 42);
            buttonStartPredict.TabIndex = 1;
            buttonStartPredict.Text = "Start Prediction";
            buttonStartPredict.UseVisualStyleBackColor = true;
            buttonStartPredict.Click += buttonStartPredict_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label1PriceResult);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(16, 481);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 91);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.LightSeaGreen;
            label13.Location = new Point(422, 29);
            label13.Name = "label13";
            label13.Size = new Size(42, 51);
            label13.TabIndex = 0;
            label13.Text = "$";
            // 
            // label1PriceResult
            // 
            label1PriceResult.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1PriceResult.Location = new Point(49, 35);
            label1PriceResult.Name = "label1PriceResult";
            label1PriceResult.Size = new Size(367, 45);
            label1PriceResult.TabIndex = 0;
            label1PriceResult.Text = "000000.00";
            label1PriceResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(275, 134);
            label8.TabIndex = 0;
            label8.Text = "House Price Prediction";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 589);
            Controls.Add(pictureBox1);
            Controls.Add(buttonStartPredict);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HPP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBathRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBedRoms).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxCommunityType;
        private NumericUpDown numericUpDownBathRooms;
        private Label label6;
        private NumericUpDown numericUpDownBedRoms;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox textBoxArea;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonStartPredict;
        private GroupBox groupBox2;
        private Label label13;
        private Label label1PriceResult;
        private PictureBox pictureBox1;
        private Label label8;
        private TextBox textBoxYearBuild;
        private Label label10;
        private Label label9;
    }
}