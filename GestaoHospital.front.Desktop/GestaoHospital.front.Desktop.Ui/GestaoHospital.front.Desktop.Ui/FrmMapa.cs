using GestaoHospital.front.Desktop.DAO;
using Microsoft.Extensions.Configuration;

namespace GestaoHospital.front.Desktop.Ui
{
    public partial class FrmMapa : Form
    {
        public FrmMapa()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {   
            MapaDAO mapaDao = new MapaDAO(Program.Configuration);
            var (sucesso, mapas) = mapaDao.ObtemMapas();
            if (sucesso && mapas.Any())
            {
                grvMapa.DataSource = mapas;
                grvMapa.AutoSize = true;
                grvMapa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            } else
            {
                LimparGrid();
                MessageBox.Show("Nenhum mapa encontrado.", "Profissionais", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LimparGrid()
        {
            grvMapa.DataSource = null;
            btnAlterar.Enabled = false;
        }
    }
}
