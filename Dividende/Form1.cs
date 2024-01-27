using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dividende
{
	public class Form1 : Form
	{
		private IContainer components;

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

		public Form1()
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

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
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
            // txtDivBrut
            // 
            this.txtDivBrut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDivBrut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDivBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivBrut.Location = new System.Drawing.Point(418, 287);
            this.txtDivBrut.Name = "txtDivBrut";
            this.txtDivBrut.Size = new System.Drawing.Size(98, 27);
            this.txtDivBrut.TabIndex = 35;
            this.txtDivBrut.Text = "0";
            this.txtDivBrut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImpDat
            // 
            this.txtImpDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtImpDat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtImpDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpDat.Location = new System.Drawing.Point(418, 249);
            this.txtImpDat.Name = "txtImpDat";
            this.txtImpDat.Size = new System.Drawing.Size(98, 27);
            this.txtImpDat.TabIndex = 34;
            this.txtImpDat.Text = "0";
            this.txtImpDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Dividende brute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Impozit datorat";
            // 
            // btnCalcNet
            // 
            this.btnCalcNet.Location = new System.Drawing.Point(285, 210);
            this.btnCalcNet.Name = "btnCalcNet";
            this.btnCalcNet.Size = new System.Drawing.Size(103, 30);
            this.btnCalcNet.TabIndex = 31;
            this.btnCalcNet.Text = "&Calculeaza";
            this.btnCalcNet.UseVisualStyleBackColor = true;
            this.btnCalcNet.Click += new System.EventHandler(this.btnCalcNet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "%";
            // 
            // txtImpCota
            // 
            this.txtImpCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpCota.Location = new System.Drawing.Point(416, 169);
            this.txtImpCota.Name = "txtImpCota";
            this.txtImpCota.ReadOnly = false;
            this.txtImpCota.Size = new System.Drawing.Size(100, 26);
            this.txtImpCota.TabIndex = 29;
            this.txtImpCota.Text = "5";
            this.txtImpCota.TextChanged += new System.EventHandler(this.txtImpCota_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Procent impozit dividende";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Lei";
            // 
            // txtDivNet
            // 
            this.txtDivNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivNet.Location = new System.Drawing.Point(416, 137);
            this.txtDivNet.Name = "txtDivNet";
            this.txtDivNet.Size = new System.Drawing.Size(100, 26);
            this.txtDivNet.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Dividende platite (net)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lei";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void txtImpCota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}