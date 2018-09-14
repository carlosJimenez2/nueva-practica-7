using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        int i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] NombreCompletoArray = new string[7, 4] { { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" }, { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" }, { "LAGUNA", "LOPEZ", "LUIS ANTONIO", "313067136" }, { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" }, { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" }, { "SOSA", "CORONA", "MILTON OSMAR", "314308067" }, { "Uribe", "Serralde", "Armando", "314104326" } };

            string[][] NombreCompletoJArray = new string[7][];

            NombreCompletoJArray[0] = new string[] { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" };
            NombreCompletoJArray[1] = new string[] { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" };
            NombreCompletoJArray[2] = new string[] { "LAGUNA", "LOPEZ", "LUIS ANTONIO", "313067136" };
            NombreCompletoJArray[3] = new string[] { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" };
            NombreCompletoJArray[4] = new string[] { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" };
            NombreCompletoJArray[5] = new string[] { "SOSA", "CORONA", "MILTON OSMAR", "314308067" };
            NombreCompletoJArray[6] = new string[] { "Uribe", "Serralde", "Armando", "314104326" };

            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Apellido paterno";
            dataGridView3.Columns[1].Name = "Apellido materno";
            dataGridView3.Columns[2].Name = "Nombre";
            dataGridView3.Columns[3].Name = "Numero de cuenta";

            dataGridView4.ColumnCount = 4;
            dataGridView4.Columns[0].Name = "Apellido paterno";
            dataGridView4.Columns[1].Name = "Apellido materno";
            dataGridView4.Columns[2].Name = "Nombre";
            dataGridView4.Columns[3].Name = "Numero de cuenta";

            for (int i = 0; i < 7; i++)
            {
                dataGridView4.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = NombreCompletoJArray[i][j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = NombreCompletoArray[i, j];

                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
