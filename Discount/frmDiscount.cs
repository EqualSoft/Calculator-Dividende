using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Discount
{
	public class frmDiscount : Form
	{
		private IContainer components;

		private Label label1;

		private Label label2;

		private TextBox txtOrginal_Price;

		private TextBox txtDiscount_Percent;

		private Label label5;

		private Button btnCalculate;

		private Label label6;

		private Label label7;

		private Label lblDiscount_Price;

		private Label lblAmount_Save;

		private Label txtDivBrut;

		private Label txtImpDat;

		private Label label10;

		private Label label11;

		private Button btnCalcNet;

		private Label label12;

		private TextBox txtImpCota;

		private Label label13;

		private Label label14;

		private TextBox txtDivNet;

		private Label label15;

		private Label label4;

		private Label label3;

		public frmDiscount()
		{
			this.InitializeComponent();
		}

		private void btnCalcNet_Click(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(this.txtDivNet.Text.Trim());
			double num1 = Convert.ToDouble(this.txtImpCota.Text.Trim());
			double num2 = num / (100 - num1) * 100;
			double num3 = num2 - num;
			this.txtImpDat.Text = num3.ToString("0.00");
			this.txtDivBrut.Text = num2.ToString("0.00");
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(this.txtOrginal_Price.Text.Trim());
			double num1 = Convert.ToDouble(this.txtDiscount_Percent.Text.Trim());
			double num2 = num * num1 / 100;
			double num3 = num - num2;
			this.lblDiscount_Price.Text = num2.ToString("0.00");
			this.lblAmount_Save.Text = num3.ToString("0.00");
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrginal_Price = new System.Windows.Forms.TextBox();
            this.txtDiscount_Percent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiscount_Price = new System.Windows.Forms.Label();
            this.lblAmount_Save = new System.Windows.Forms.Label();
            this.txtDivBrut = new System.Windows.Forms.Label();
            this.txtImpDat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcNet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImpCota = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDivNet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator Dividende -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dividende platite (brut)";
            // 
            // txtOrginal_Price
            // 
            this.txtOrginal_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginal_Price.Location = new System.Drawing.Point(146, 46);
            this.txtOrginal_Price.Name = "txtOrginal_Price";
            this.txtOrginal_Price.Size = new System.Drawing.Size(100, 26);
            this.txtOrginal_Price.TabIndex = 2;
            // 
            // txtDiscount_Percent
            // 
            this.txtDiscount_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount_Percent.Location = new System.Drawing.Point(146, 78);
            this.txtDiscount_Percent.Name = "txtDiscount_Percent";
            this.txtDiscount_Percent.Size = new System.Drawing.Size(100, 26);
            this.txtDiscount_Percent.TabIndex = 5;
            this.txtDiscount_Percent.Text = "8";
            this.txtDiscount_Percent.TextChanged += new System.EventHandler(this.txtDiscount_Percent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Procent impozit dividende";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 119);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculeaza";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dividende nete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Impozit datorat";
            // 
            // lblDiscount_Price
            // 
            this.lblDiscount_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDiscount_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscount_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount_Price.Location = new System.Drawing.Point(148, 158);
            this.lblDiscount_Price.Name = "lblDiscount_Price";
            this.lblDiscount_Price.Size = new System.Drawing.Size(98, 27);
            this.lblDiscount_Price.TabIndex = 10;
            this.lblDiscount_Price.Text = "0";
            this.lblDiscount_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount_Save
            // 
            this.lblAmount_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAmount_Save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount_Save.Location = new System.Drawing.Point(148, 196);
            this.lblAmount_Save.Name = "lblAmount_Save";
            this.lblAmount_Save.Size = new System.Drawing.Size(98, 27);
            this.lblAmount_Save.TabIndex = 11;
            this.lblAmount_Save.Text = "0";
            this.lblAmount_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDivBrut
            // 
            this.txtDivBrut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDivBrut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDivBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivBrut.Location = new System.Drawing.Point(511, 202);
            this.txtDivBrut.Name = "txtDivBrut";
            this.txtDivBrut.Size = new System.Drawing.Size(98, 27);
            this.txtDivBrut.TabIndex = 48;
            this.txtDivBrut.Text = "0";
            this.txtDivBrut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImpDat
            // 
            this.txtImpDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtImpDat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtImpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpDat.Location = new System.Drawing.Point(511, 164);
            this.txtImpDat.Name = "txtImpDat";
            this.txtImpDat.Size = new System.Drawing.Size(98, 27);
            this.txtImpDat.TabIndex = 47;
            this.txtImpDat.Text = "0";
            this.txtImpDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Dividende brute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Impozit datorat";
            // 
            // btnCalcNet
            // 
            this.btnCalcNet.Location = new System.Drawing.Point(378, 125);
            this.btnCalcNet.Name = "btnCalcNet";
            this.btnCalcNet.Size = new System.Drawing.Size(103, 30);
            this.btnCalcNet.TabIndex = 44;
            this.btnCalcNet.Text = "&Calculeaza";
            this.btnCalcNet.UseVisualStyleBackColor = true;
            this.btnCalcNet.Click += new System.EventHandler(this.btnCalcNet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(617, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "%";
            // 
            // txtImpCota
            // 
            this.txtImpCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpCota.Location = new System.Drawing.Point(509, 84);
            this.txtImpCota.Name = "txtImpCota";
            this.txtImpCota.Size = new System.Drawing.Size(100, 26);
            this.txtImpCota.TabIndex = 42;
            this.txtImpCota.Text = "8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Procent impozit dividende";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(617, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Lei";
            // 
            // txtDivNet
            // 
            this.txtDivNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivNet.Location = new System.Drawing.Point(509, 52);
            this.txtDivNet.Name = "txtDivNet";
            this.txtDivNet.Size = new System.Drawing.Size(100, 26);
            this.txtDivNet.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Dividende platite (net)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lei";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 284);
            this.Controls.Add(this.txtDivBrut);
            this.Controls.Add(this.txtImpDat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcNet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtImpCota);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDivNet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmount_Save);
            this.Controls.Add(this.lblDiscount_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiscount_Percent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrginal_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiscount";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividende";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void label8_Click(object sender, EventArgs e)
		{
		}

		private void labelHello_Click(object sender, EventArgs e)
		{
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtDiscount_Percent_TextChanged(object sender, EventArgs e)
		{
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}