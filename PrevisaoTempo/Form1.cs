using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace PrevisaoTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double ToCelsius(double kelvin)
        {
            return Convert.ToInt32(kelvin - 273.15);
        }

        string OpenWeatherKey = "d3a690b128e500aa56dded73551bda8c";

        void GetPrevisao()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&lang=pt", txtCidade.Text, OpenWeatherKey);
                var json = web.DownloadString(url);
                InfoTempo.root Info = JsonConvert.DeserializeObject<InfoTempo.root>(json);

                pbTempoIcone.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon + "@2x.png";
                lbDescricao.Text = Info.weather[0].description;
                lbSensacaoTermica.Text = ToCelsius(Info.main.feels_like).ToString() + '°';
                lbTemperatura.Text = ToCelsius(Info.main.temp).ToString() + '°';
                lbTemperaturaMinMax.Text = ToCelsius(Info.main.temp_min).ToString() + '°' + '/' + ToCelsius(Info.main.temp_max).ToString() + '°';
                label2.Visible = true;
                lbDescricao.Visible = true;
            }
        }

        private void btnProcurarCidade_Click(object sender, EventArgs e)
        {
            try
            {
                GetPrevisao();
            }
            catch
            {
                MessageBox.Show("Cidade inválida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Text = DateTime.Today.ToLongDateString();
        }
    }
}
