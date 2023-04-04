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

                pbTempoIcone.ImageLocation = "https://openweathermap.org/img/w" + Info.tempo[0].icone + ".png";
                lbCondicao.Text = Info.tempo[0].main;
                lbDescricao.Text = Info.tempo[0].descricao;
                lbSensacaoTermica.Text = Info.main.sensaTermica.ToString();
                lbTemperatura.Text = Info.main.temperatura.ToString();
                lbTemperaturaMax.Text = Info.main.tempMax.ToString();
                lbTemperaturaMin.Text = Info.main.tempMin.ToString();
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
