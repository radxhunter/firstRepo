namespace SamochodElektrycznyKalkulacja1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearsNUD = new System.Windows.Forms.NumericUpDown();
            this.kmPerYearNUD = new System.Windows.Forms.NumericUpDown();
            this.petrolPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.fuelConsumptionNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmPerYearNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość kilometrów rocznie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sumaryczny koszt benzyny:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(237, 149);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(53, 20);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Kwota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Planowany czas użytkowania\r\nw latach:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cena benzyny";
            // 
            // yearsNUD
            // 
            this.yearsNUD.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yearsNUD.Location = new System.Drawing.Point(186, 63);
            this.yearsNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.yearsNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yearsNUD.Name = "yearsNUD";
            this.yearsNUD.Size = new System.Drawing.Size(120, 20);
            this.yearsNUD.TabIndex = 10;
            this.yearsNUD.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yearsNUD.ValueChanged += new System.EventHandler(this.fuelConsumptionNUD_ValueChanged);
            // 
            // kmPerYearNUD
            // 
            this.kmPerYearNUD.Location = new System.Drawing.Point(186, 96);
            this.kmPerYearNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.kmPerYearNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kmPerYearNUD.Name = "kmPerYearNUD";
            this.kmPerYearNUD.Size = new System.Drawing.Size(120, 20);
            this.kmPerYearNUD.TabIndex = 11;
            this.kmPerYearNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kmPerYearNUD.ValueChanged += new System.EventHandler(this.fuelConsumptionNUD_ValueChanged);
            // 
            // petrolPriceNUD
            // 
            this.petrolPriceNUD.DecimalPlaces = 1;
            this.petrolPriceNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.petrolPriceNUD.Location = new System.Drawing.Point(501, 66);
            this.petrolPriceNUD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.petrolPriceNUD.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.petrolPriceNUD.Name = "petrolPriceNUD";
            this.petrolPriceNUD.Size = new System.Drawing.Size(120, 20);
            this.petrolPriceNUD.TabIndex = 12;
            this.petrolPriceNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.petrolPriceNUD.ValueChanged += new System.EventHandler(this.fuelConsumptionNUD_ValueChanged);
            // 
            // fuelConsumptionNUD
            // 
            this.fuelConsumptionNUD.DecimalPlaces = 1;
            this.fuelConsumptionNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fuelConsumptionNUD.Location = new System.Drawing.Point(501, 88);
            this.fuelConsumptionNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.fuelConsumptionNUD.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.fuelConsumptionNUD.Name = "fuelConsumptionNUD";
            this.fuelConsumptionNUD.Size = new System.Drawing.Size(120, 20);
            this.fuelConsumptionNUD.TabIndex = 14;
            this.fuelConsumptionNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fuelConsumptionNUD.ValueChanged += new System.EventHandler(this.fuelConsumptionNUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Spalanie na 100km";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameLabel.Location = new System.Drawing.Point(124, 25);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(142, 20);
            this.carNameLabel.TabIndex = 16;
            this.carNameLabel.Text = "nazwa samochodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Samochód:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 200);
            this.Controls.Add(this.carNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fuelConsumptionNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.petrolPriceNUD);
            this.Controls.Add(this.kmPerYearNUD);
            this.Controls.Add(this.yearsNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmPerYearNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yearsNUD;
        private System.Windows.Forms.NumericUpDown kmPerYearNUD;
        private System.Windows.Forms.NumericUpDown petrolPriceNUD;
        private System.Windows.Forms.NumericUpDown fuelConsumptionNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label carNameLabel;
        private System.Windows.Forms.Label label7;
    }
}

