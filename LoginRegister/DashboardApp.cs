using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCharts(); // Llamada para inicializar las series en los gráficos
        }

        /// <summary>
        /// Inicializa los gráficos asegurando que las series "Consumo" existan.
        /// </summary>
        private void InitializeCharts()
        {
            // Verificar y agregar serie "Consumo" a chartEnergy si no existe
            if (chartEnergy.Series.IndexOf("Consumo") == -1)
            {
                chartEnergy.Series.Add("Consumo");
                chartEnergy.Series["Consumo"].ChartType = SeriesChartType.Column;
            }

            // Verificar y agregar serie "Consumo" a chartWater si no existe
            if (chartWater.Series.IndexOf("Consumo") == -1)
            {
                chartWater.Series.Add("Consumo");
                chartWater.Series["Consumo"].ChartType = SeriesChartType.Column;
            }
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de consumo de energía y agua desde los cuadros de texto
                double energiaConsumida = double.Parse(txtEnergyConsumption.Text);
                double aguaConsumida = double.Parse(txtWaterConsumption.Text);

                // Cálculos del consumo y las recomendaciones
                double energiaMaxima = 150; // Límite máximo de energía para el mes (en kWh)
                double aguaMaxima = 30; // Límite máximo de agua para el mes (en metros cúbicos)

                // Tarifas por kWh y m³ según estimaciones en Nicaragua
                double tarifaEnergiaBaja = 0.10; // Tarifa para los primeros 150 kWh
                double tarifaEnergiaAlta = 0.15; // Tarifa para el consumo que supera los 150 kWh
                double tarifaAguaBaja = 0.30; // Tarifa por m³ para consumo bajo
                double tarifaAguaAlta = 0.50; // Tarifa por m³ para consumo alto

                // Ajuste de tarifas de energía si el consumo supera ciertos umbrales
                if (energiaConsumida > 100 && energiaConsumida <= 125)
                {
                    tarifaEnergiaAlta *= 1.07;  // Aumento del 7%
                }
                else if (energiaConsumida > 125)
                {
                    tarifaEnergiaAlta *= 1.10;  // Aumento del 10%
                }

                // Cálculos de costos de energía y agua en dólares
                double costoEnergiaUSD = (energiaConsumida <= energiaMaxima)
                    ? energiaConsumida * tarifaEnergiaBaja
                    : energiaMaxima * tarifaEnergiaBaja + (energiaConsumida - energiaMaxima) * tarifaEnergiaAlta;

                double costoAguaUSD = (aguaConsumida <= aguaMaxima)
                    ? aguaConsumida * tarifaAguaBaja
                    : aguaMaxima * tarifaAguaBaja + (aguaConsumida - aguaMaxima) * tarifaAguaAlta;

                // Factor de conversión de USD a Córdobas (ejemplo: 1 USD = 36 Córdobas)
                double tipoDeCambio = 36.0;

                // Convertir los costos de USD a Córdobas
                double costoEnergiaCords = costoEnergiaUSD * tipoDeCambio;
                double costoAguaCords = costoAguaUSD * tipoDeCambio;

                // Calcular el consumo estimado en la semana
                double consumoSemanalEnergia = energiaConsumida / 7;
                double consumoSemanalAgua = aguaConsumida / 7;

                // Mostrar los resultados de los cálculos en lblAdvice
                lblAdvice.Text = $"Consumo semanal de energía: {consumoSemanalEnergia:0.00} kWh\n";
                lblAdvice.Text += $"Consumo semanal de agua: {consumoSemanalAgua:0.00} m³\n";
                lblAdvice.Text += $"Costo estimado de energía (mensual): {costoEnergiaCords:0.00} Córdobas\n";
                lblAdvice.Text += $"Costo estimado de agua (mensual): {costoAguaCords:0.00} Córdobas\n";

                // Generar recomendaciones basadas en los consumos
                lblAdvice.Text += (energiaConsumida > energiaMaxima)
                    ? "¡Alerta! Estás consumiendo más energía de la recomendada."
                    : "Tu consumo de energía está dentro de los límites.";

                lblAdvice.Text += (aguaConsumida > aguaMaxima)
                    ? "\n¡Alerta! Estás consumiendo más agua de la recomendada."
                    : "\nTu consumo de agua está dentro de los límites.";

                // Actualizar los gráficos con los datos de consumo
                chartEnergy.Series["Consumo"].Points.Clear();
                chartWater.Series["Consumo"].Points.Clear();

                chartEnergy.Series["Consumo"].Points.AddY(consumoSemanalEnergia);
                chartWater.Series["Consumo"].Points.AddY(consumoSemanalAgua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los cálculos: " + ex.Message);
            }
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing data for the last 7 days.");
        }

        private void btnLast15Days_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing data for the last 15 days.");
        }

        private void btnCurrentMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing data for the current month.");
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing data for the previous month.");
        }
    }
}





