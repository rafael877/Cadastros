using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class FrmJogos : Form
    {
        public FrmJogos()
        {
            InitializeComponent();
        }

        private void jogosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmJogos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Jogos'. Você pode movê-la ou removê-la conforme necessário.
            this.jogosTableAdapter.Fill(this.dataSet1.Jogos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void jogosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
