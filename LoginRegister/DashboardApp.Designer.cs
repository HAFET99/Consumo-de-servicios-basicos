using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Button btnCalcular2;
        private Guna2Button btnLast7Days;
        private Guna2Button btnLast15Days;
        private Guna2Button btnCurrentMonth;
        private Guna2Button btnPreviousMonth;
        private Guna2TextBox txtWaterConsumption;
        private Guna2TextBox txtEnergyConsumption;
        private Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdvice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnergy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWater;



        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLast7Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast15Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreviousMonth = new Guna.UI2.WinForms.Guna2Button();
            this.txtWaterConsumption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnergyConsumption = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.chartEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWater = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAdvice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCalcular2 = new Guna.UI2.WinForms.Guna2Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWater)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Animated = true;
            this.btnLast7Days.BackColor = System.Drawing.Color.Transparent;
            this.btnLast7Days.BorderRadius = 30;
            this.btnLast7Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLast7Days.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLast7Days.ForeColor = System.Drawing.Color.White;
            this.btnLast7Days.Location = new System.Drawing.Point(20, 20);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(160, 45);
            this.btnLast7Days.TabIndex = 0;
            this.btnLast7Days.Text = "Últimos 7 Dias";
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2 = new Guna.UI2.WinForms.Guna2Button(); // Declarar el botón correctamente
            this.btnCalcular2.Animated = true;
            this.btnCalcular2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular2.BorderRadius = 30;
            this.btnCalcular2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCalcular2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(500, 150);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(160, 45);
            this.btnCalcular2.TabIndex = 0;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);

            // 
            // btnLast15Days
            // 
            this.btnLast15Days.Animated = true;
            this.btnLast15Days.BackColor = System.Drawing.Color.Transparent;
            this.btnLast15Days.BorderRadius = 30;
            this.btnLast15Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLast15Days.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLast15Days.ForeColor = System.Drawing.Color.White;
            this.btnLast15Days.Location = new System.Drawing.Point(200, 20);
            this.btnLast15Days.Name = "btnLast15Days";
            this.btnLast15Days.Size = new System.Drawing.Size(160, 45);
            this.btnLast15Days.TabIndex = 1;
            this.btnLast15Days.Text = "Últimos 15 Dias";
            this.btnLast15Days.Click += new System.EventHandler(this.btnLast15Days_Click);
            // 
            // btnCurrentMonth
            // 
            this.btnCurrentMonth.Animated = true;
            this.btnCurrentMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentMonth.BorderRadius = 30;
            this.btnCurrentMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCurrentMonth.ForeColor = System.Drawing.Color.White;
            this.btnCurrentMonth.Location = new System.Drawing.Point(380, 20);
            this.btnCurrentMonth.Name = "btnCurrentMonth";
            this.btnCurrentMonth.Size = new System.Drawing.Size(160, 45);
            this.btnCurrentMonth.TabIndex = 2;
            this.btnCurrentMonth.Text = "Mes Actual";
            this.btnCurrentMonth.Click += new System.EventHandler(this.btnCurrentMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Animated = true;
            this.btnPreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.BorderRadius = 30;
            this.btnPreviousMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPreviousMonth.ForeColor = System.Drawing.Color.White;
            this.btnPreviousMonth.Location = new System.Drawing.Point(560, 20);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(160, 45);
            this.btnPreviousMonth.TabIndex = 3;
            this.btnPreviousMonth.Text = "Mes Anterior";
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // txtWaterConsumption
            // 
            this.txtWaterConsumption.Animated = true;
            this.txtWaterConsumption.BackColor = System.Drawing.Color.Transparent;
            this.txtWaterConsumption.BorderRadius = 25;
            this.txtWaterConsumption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWaterConsumption.DefaultText = "";
            this.txtWaterConsumption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWaterConsumption.Location = new System.Drawing.Point(20, 80);
            this.txtWaterConsumption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWaterConsumption.Name = "txtWaterConsumption";
            this.txtWaterConsumption.PasswordChar = '\0';
            this.txtWaterConsumption.PlaceholderText = "Consumo Agua (litros)";
            this.txtWaterConsumption.SelectedText = "";
            this.txtWaterConsumption.Size = new System.Drawing.Size(250, 35);
            this.txtWaterConsumption.TabIndex = 4;
            // 
            // txtEnergyConsumption
            // 
            this.txtEnergyConsumption.Animated = true;
            this.txtEnergyConsumption.BackColor = System.Drawing.Color.Transparent;
            this.txtEnergyConsumption.BorderRadius = 25;
            this.txtEnergyConsumption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnergyConsumption.DefaultText = "";
            this.txtEnergyConsumption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnergyConsumption.Location = new System.Drawing.Point(280, 80);
            this.txtEnergyConsumption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnergyConsumption.Name = "txtEnergyConsumption";
            this.txtEnergyConsumption.PasswordChar = '\0';
            this.txtEnergyConsumption.PlaceholderText = "Consumo Energía (kWh)";
            this.txtEnergyConsumption.SelectedText = "";
            this.txtEnergyConsumption.Size = new System.Drawing.Size(250, 35);
            this.txtEnergyConsumption.TabIndex = 5;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.chartEnergy);
            this.panelData.Controls.Add(this.chartWater);
            this.panelData.Controls.Add(this.lblAdvice);
            this.panelData.Location = new System.Drawing.Point(12, 122);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(700, 450);
            this.panelData.TabIndex = 6;
            // 
            // chartEnergy
            // 
            chartArea1.Name = "EnergyArea";
            this.chartEnergy.ChartAreas.Add(chartArea1);
            legend1.Name = "EnergyLegend";
            this.chartEnergy.Legends.Add(legend1);
            this.chartEnergy.Location = new System.Drawing.Point(10, 10);
            this.chartEnergy.Name = "chartEnergy";
            series1.ChartArea = "EnergyArea";
            series1.Legend = "EnergyLegend";
            series1.Name = "Energy";
            this.chartEnergy.Series.Add(series1);
            this.chartEnergy.Size = new System.Drawing.Size(320, 200);
            this.chartEnergy.TabIndex = 0;
            // 
            // chartWater
            // 
            chartArea2.Name = "WaterArea";
            this.chartWater.ChartAreas.Add(chartArea2);
            legend2.Name = "WaterLegend";
            this.chartWater.Legends.Add(legend2);
            this.chartWater.Location = new System.Drawing.Point(350, 10);
            this.chartWater.Name = "chartWater";
            series2.ChartArea = "WaterArea";
            series2.Legend = "WaterLegend";
            series2.Name = "Water";
            this.chartWater.Series.Add(series2);
            this.chartWater.Size = new System.Drawing.Size(320, 200);
            this.chartWater.TabIndex = 1;
            // 
            // lblAdvice
            // 
            this.lblAdvice.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvice.ForeColor = System.Drawing.Color.Black;
            this.lblAdvice.Location = new System.Drawing.Point(10, 235);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(283, 18);
            this.lblAdvice.TabIndex = 2;
            this.lblAdvice.Text = "Consejo: ¡Controla tu consumo periódicamente!";
            // 
            // btncalcular2
            // 
            this.btnCalcular2.Animated = true;
            this.btnCalcular2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular2.BorderRadius = 30;
            this.btnCalcular2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCalcular2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(536, 81);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(107, 34);
            this.btnCalcular2.TabIndex = 7;
            this.btnCalcular2.Text = "calcular";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(744, 597);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast15Days);
            this.Controls.Add(this.btnCurrentMonth);
            this.Controls.Add(this.btnPreviousMonth);
            this.Controls.Add(this.txtWaterConsumption);
            this.Controls.Add(this.txtEnergyConsumption);
            this.Controls.Add(this.panelData);
            this.Name = "Form1";
            this.Text = "Consumo de Agua & Energia Dashboard";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWater)).EndInit();
            this.ResumeLayout(false);

        }


    }
}



