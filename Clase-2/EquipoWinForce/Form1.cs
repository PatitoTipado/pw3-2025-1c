using System.Text.Json;
using System.Text;
using Clase2.Entidad;

namespace EquipoWinForce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnObtenerEquipos_Click(object sender, EventArgs e)
        {
            DgvEquipos.Rows.Clear();
            ObtenerResultadosDeAPI();
        }
        private async Task ObtenerResultadosDeAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.GetAsync("equipo");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var equipos = JsonSerializer.Deserialize<List<Equipo>>(jsonResponse);
                    foreach (var equipo in equipos)
                    {
                        CargarGrillaResultados(equipo);
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los resultados de la API.");
                }
            }

        }

        private void BtnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipoAux = new Equipo();

            equipoAux.nombre = TxtNombreEquipo.Text;
            equipoAux.pais = TxtPaisEquipo.Text;

            AgregarEquipo(equipoAux);
        }

        private async Task AgregarEquipo(Equipo equipo)
        {
            var jsonContento = JsonSerializer.Serialize(equipo);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.PostAsync("equipo", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Resultado registrado en la API.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el resultado en la API.");
                }
            }
        }

        private void CargarGrillaResultados(Equipo equipo)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DgvEquipos);
            row.Cells[0].Value = equipo.nombre;
            row.Cells[1].Value = equipo.pais;

            DgvEquipos.Rows.Add(row);
        }

        private void BtnEliminarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipoAux = new Equipo();

            equipoAux.nombre = TxtNombreEquipo.Text;
            equipoAux.pais = TxtPaisEquipo.Text;

            EliminarEquipo(equipoAux);
        }

        private async Task EliminarEquipo(Equipo equipo)
        {
            var jsonContento = JsonSerializer.Serialize(equipo);
            var content = new StringContent(jsonContento, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7120/api/");
                var response = await client.DeleteAsync($"equipo/{equipo.nombre}/{equipo.pais}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("El equipo fue eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar equipo no se encontro dicho equipo.");
                }
            }
        }
    
    }
}
