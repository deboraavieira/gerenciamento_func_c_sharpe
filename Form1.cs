using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _3935_Tarefa04_DeboraVieira
{
    public partial class Form1 : Form
    {
        String[,] funcionario = new string[9, 7]; 
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MostraFunc()
        {
            lbl_numero.Text = funcionario[index, 0];
            lbl_nome.Text = funcionario[index,1];
            lbl_genero.Text = funcionario[index,2];
            lbl_dtNasc.Text = funcionario[index,3];
            lbl_nacionalidade.Text = funcionario[index,4];
            lbl_categoria.Text = funcionario[index,5];
            pic_foto.ImageLocation = funcionario[index,6];

            

        }
        private void CalcIdade()
        {
            DateTime ano_atual = DateTime.Today;
            DateTime dtNasc = DateTime.ParseExact(lbl_dtNasc.Text, "dd-MM-yyyy", new CultureInfo("pt-PT"));

            int idade = ano_atual.Year - dtNasc.Year;
            if (ano_atual.Month < dtNasc.Month || (ano_atual.Month == ano_atual.Month && ano_atual.Day < dtNasc.Day))
            {
                idade--;
            }
            lbl_idade.Text = idade.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fic = new StreamReader("funcionarios.txt");

            do
            {
                string linha = fic.ReadLine();
                string[] coluna = linha.Split(',');

                funcionario[index,0]=   coluna[0];
                funcionario[index, 1] = coluna[1];
                funcionario[index, 2] = coluna[2];
                funcionario[index, 3] = coluna[3];
                funcionario[index, 4] = coluna[4];
                funcionario[index, 5] = coluna[5];
                funcionario[index, 6] = coluna[6];
                index++;
                
            } while(fic.Peek() != -1);
            fic.Close();
            index = 0;
            MostraFunc();
            CalcIdade();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            index = 0;
            MostraFunc();
            CalcIdade();
        }

        private void btn_fim_Click(object sender, EventArgs e)
        {
            index = 8;
            MostraFunc();
            CalcIdade();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                MessageBox.Show("Não há mais funcionários a serem exibidos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                index = 8;
            }
            MostraFunc();
            CalcIdade();

        }

        private void btn_seguinte_Click(object sender, EventArgs e)
        {
            index++;
            if(index > 8)
            {
                MessageBox.Show("Não há mais funcionários a serem exibidos.", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                index = 0;
            }
            MostraFunc();
            CalcIdade();
        }
        private void pic_1_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[0,0];
            lbl_nome.Text = funcionario[0, 1];
            lbl_genero.Text = funcionario[0, 2];
            lbl_dtNasc.Text = funcionario[0, 3];
            lbl_nacionalidade.Text = funcionario[0, 4];
            lbl_categoria.Text = funcionario[0, 5];
            pic_foto.ImageLocation = funcionario[0, 6];
            CalcIdade();
        }
        private void pic_2_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[1, 0];
            lbl_nome.Text = funcionario[1, 1];
            lbl_genero.Text = funcionario[1, 2];
            lbl_dtNasc.Text = funcionario[1, 3];
            lbl_nacionalidade.Text = funcionario[1, 4];
            lbl_categoria.Text = funcionario[1, 5];
            pic_foto.ImageLocation = funcionario[1, 6];
            CalcIdade();
        }

        private void pic_3_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[2, 0];
            lbl_nome.Text = funcionario[2, 1];
            lbl_genero.Text = funcionario[2, 2];
            lbl_dtNasc.Text = funcionario[2, 3];
            lbl_nacionalidade.Text = funcionario[2, 4];
            lbl_categoria.Text = funcionario[2, 5];
            pic_foto.ImageLocation = funcionario[2, 6];
            CalcIdade();
        }
        private void pic_4_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[3, 0];
            lbl_nome.Text = funcionario[3, 1];
            lbl_genero.Text = funcionario[3, 2];
            lbl_dtNasc.Text = funcionario[3, 3];
            lbl_nacionalidade.Text = funcionario[3, 4];
            lbl_categoria.Text = funcionario[3, 5];
            pic_foto.ImageLocation = funcionario[3, 6];
            CalcIdade();
        }

        private void pic_5_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[4, 0];
            lbl_nome.Text = funcionario[4, 1];
            lbl_genero.Text = funcionario[4, 2];
            lbl_dtNasc.Text = funcionario[4, 3];
            lbl_nacionalidade.Text = funcionario[4, 4];
            lbl_categoria.Text = funcionario[4, 5];
            pic_foto.ImageLocation = funcionario[4, 6];
            CalcIdade();
        }
        private void pic_6_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[5, 0];
            lbl_nome.Text = funcionario[5, 1];
            lbl_genero.Text = funcionario[5, 2];
            lbl_dtNasc.Text = funcionario[5, 3];
            lbl_nacionalidade.Text = funcionario[5, 4];
            lbl_categoria.Text = funcionario[5, 5];
            pic_foto.ImageLocation = funcionario[5, 6];
            CalcIdade();
        }
        private void pic_7_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[6, 0];
            lbl_nome.Text = funcionario[6, 1];
            lbl_genero.Text = funcionario[6, 2];
            lbl_dtNasc.Text = funcionario[6, 3];
            lbl_nacionalidade.Text = funcionario[6, 4];
            lbl_categoria.Text = funcionario[6, 5];
            pic_foto.ImageLocation = funcionario[6, 6];
            CalcIdade();
        }

        private void pic_8_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[7, 0];
            lbl_nome.Text = funcionario[7, 1];
            lbl_genero.Text = funcionario[7, 2];
            lbl_dtNasc.Text = funcionario[7, 3];
            lbl_nacionalidade.Text = funcionario[7, 4];
            lbl_categoria.Text = funcionario[7, 5];
            pic_foto.ImageLocation = funcionario[7, 6];
            CalcIdade();
        }

        private void pic_9_MouseHover(object sender, EventArgs e)
        {
            lbl_numero.Text = funcionario[8, 0];
            lbl_nome.Text = funcionario[8, 1];
            lbl_genero.Text = funcionario[8, 2];
            lbl_dtNasc.Text = funcionario[8, 3];
            lbl_nacionalidade.Text = funcionario[8, 4];
            lbl_categoria.Text = funcionario[8, 5];
            pic_foto.ImageLocation = funcionario[8, 6];
            CalcIdade();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f1 = new Font("Arial Nova", 16);
            Font f2 = new Font("Times New Roman", 12);

            e.Graphics.DrawString("Funcionários", f1, new SolidBrush(Color.DarkBlue), 100, 50);
       
           
            e.Graphics.DrawString("Número: " + lbl_numero.Text, f2, new SolidBrush(Color.Black), 100, 105);
            e.Graphics.DrawString("Nome: " + lbl_nome.Text, f2, new SolidBrush(Color.Black), 100, 130);
            e.Graphics.DrawString("Género: " + lbl_genero.Text,f2, new SolidBrush(Color.Black), 100, 155);
            e.Graphics.DrawString("Data de Nascimento: " + lbl_dtNasc.Text, f2, new SolidBrush(Color.Black), 100, 180);
            e.Graphics.DrawString("Nacionalidade: "+lbl_nacionalidade.Text, f2, new SolidBrush(Color.Black), 100, 205);
            e.Graphics.DrawString("Categoria: "+lbl_categoria.Text, f2, new SolidBrush(Color.Black), 100, 230);

            e.Graphics.DrawImage(pic_foto.Image, 450, 100, 200, 200);

        }


    }
}
