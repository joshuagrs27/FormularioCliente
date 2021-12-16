using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using ApiWindows.Models;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {
        List<TextBox> Tex = new List<TextBox>();
        Label lb;
        TextBox ct;
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            txtNaves.Visible = false;
            txtidCuerpo.Visible = false;
            txtDescripcion.Visible = false;
            txtDuracion.Visible = false;
            txtNtripulantes.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {

            panel2.BackColor = Color.Yellow;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, 51, 73);
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string tabla = cbConsulta.Text;
            dataGridView1.Refresh();
            string respuesta = await GetHttp();
           

            switch (tabla)
            {
                case "Mision": List<Mision> lol0 = JsonConvert.DeserializeObject<List<Mision>>(respuesta); dataGridView1.DataSource = lol0; ; break;
                case "Nave": List<Nave> lol1 = JsonConvert.DeserializeObject<List<Nave>>(respuesta);
                    dataGridView1.DataSource = lol1; ; break;
                case "CuerpoCeleste": List<CuerpoCeleste> lol2 = JsonConvert.DeserializeObject<List<CuerpoCeleste>>(respuesta); dataGridView1.DataSource = lol2; ; break;
                case "Usuario": List<Usuario> lol3 = JsonConvert.DeserializeObject<List<Usuario>>(respuesta); dataGridView1.DataSource = lol3; break;
                case "DistribucionMineral": List<DistribucionMineral> lol4 = JsonConvert.DeserializeObject<List<DistribucionMineral>>(respuesta); dataGridView1.DataSource = lol4; ; break;
                default: MessageBox.Show("ERROR");break;
            }

           
        }

        private async Task<string> GetHttp()
        {
            string tabla = cbConsulta.Text;
            WebRequest request = WebRequest.Create("http://localhost:58724/api/"+tabla+"s");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            
            HttpClient httpClient = new HttpClient();
            Nave nave = new Nave();
            nave.idNave = 2;
            nave.descripcion = "prueba descripcion modificar";
            nave.nombre = "nomrbe prueba 2";

            nave.nombre = "lk";
            nave.idMision = 1;

            //var httpResponse = httpClient.PostAsync("https://localhost:44388/api/Naves/2");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string tabla = cbConsulta.Text;
            dataGridView1.Refresh();

            switch (tabla)
            {
                case "Mision":
                    Mision objeto = new Mision();
                    objeto.descripcion = "" ;
                    HttpClient httpClient = new HttpClient();
                    var httpResponse = httpClient.DeleteAsync("http://localhost:58724/api/" + tabla+"s/"+txtIdDelete.Text);
                    break;
                case "Nave":
                    HttpClient httpClient1 = new HttpClient();
                    var httpResponse1 = httpClient1.DeleteAsync("http://localhost:58724/api/" + tabla+"s/"+txtIdDelete.Text);
                    break;
                case "CuerpoCeleste":
                    HttpClient httpClient2 = new HttpClient();
                    var httpResponse2 = httpClient2.DeleteAsync("http://localhost:58724/api/" + tabla + "s/" + txtIdDelete.Text);  break;

                case "Usuario":
                    HttpClient httpClient3 = new HttpClient();  var httpResponse3 = 
                       httpClient3.DeleteAsync("http://localhost:58724/api/" + tabla + "s/" + txtIdDelete.Text); break;
               
                case "DistribucionMineral": HttpClient httpClient4 = new HttpClient(); var httpResponse4 = httpClient4.DeleteAsync("http://localhost:58724/api/" + tabla + "s/" + txtIdDelete.Text); break;
                default: MessageBox.Show("ERROR"); break;
            }

            

            
        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbConsulta.Text)
            {
                case "Nave":

                    txtNombre.Visible =         true;
                    txtNaves.Visible =          true;
                    txtidCuerpo.Visible =       true;
                    txtDescripcion.Visible =    true;
                    txtDuracion.Visible =       true;
                    txtNtripulantes.Visible =   true;

                    ; break;
                case "CuerpoCeleste":; break;
                case "DistribucionMineral":; break;
                case "Mision":; break;
                case "Usuario":; break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
