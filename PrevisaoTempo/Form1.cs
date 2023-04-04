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

        string OpenWeatherKey = "d3a690b128e500aa56dded73551bda8c";

        void GetPrevisao()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&lang=pt", txtCidade.Text, OpenWeatherKey);
                var json = web.DownloadString(url);
                InfoTempo.root Info = JsonConvert.DeserializeObject<InfoTempo.root>(json);

                pbTempoIcone.ImageLocation = "https://openweathermap.org/img/w" + Info.weather[0].icon + ".png";
                lbCondicao.Text = Info.weather[0].main;
                lbDescricao.Text = Info.weather[0].description;
                lbSensacaoTermica.Text = Info.main.feels_like.ToString();
                lbTemperatura.Text = Info.main.temp.ToString();
                lbTemperaturaMax.Text = Info.main.temp_max.ToString();
                lbTemperaturaMin.Text = Info.main.temp_min.ToString();
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
    }
}
