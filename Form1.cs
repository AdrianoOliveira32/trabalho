using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Controle_de_frota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string men;

        private void validaPlacaCaracter(TextBox textbox, ErrorProvider errorProvider)
        {
            string placa = textbox.Text;
            string caracter = @"^[a-zA-Z]+$";

            if (!Regex.IsMatch(placa, caracter ) || placa.Length > 3)
            {
                errorProvider.SetError(textbox, "Placa invalida");
               
            }

           

            else
            {
                errorProvider.SetError(textbox, "");
            }

        
        }//valida placa caracter

        private void validaPlacaNum(TextBox textbox, ErrorProvider errorProvider)
        {
           

            try
            {
                int num = Convert.ToInt32(textbox.Text);
                if (num < 1 || num > 9999)
                {
                    throw new Exception();


                }

                
            }
            catch (Exception)
            {
                
               

                errorProvider.SetError(textbox, "Placa invalida");

            }
           
    
        }



        private void ValidarNome(TextBox textbox, ErrorProvider errorProvider)
        {
           
                if (!String.IsNullOrWhiteSpace(textbox.Text))
                {
                    errorProvider.SetError(textbox, "");
                   
                }
              else{
                    errorProvider.SetError(textbox, "Digete um nome"); 
                  }

        }

        private void validaNumero(TextBox texbox, ErrorProvider errorProvider)
        {

            try
            {
                
                int numero = Convert.ToInt32(texbox.Text);
                if (numero <=0 || numero >20000)
                {
                    throw new Exception();

                }


            }
            catch (Exception e)
            {

                errorProvider.SetError(texbox, "Número inválido.");
               
            }






        }

      
        private void validaEmail(TextBox texbox, ErrorProvider errorProvider)
        {

            string email = texbox.Text;
            string modelo = @"[\w\.-]+(\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProvider.SetError(texbox, "");


            }
            else
            {

                errorProvider.SetError(texbox, "Email inválido");
            }



        }


        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

            mbCpf.Clear();
            mtbDtNasc.Clear();
            tbNome.Clear();
            tbRua.Clear();
            mtbtel.Clear();
            mtbcel.Clear();
            tbEmail.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            errorProvider.Clear();
            
            ValidarNome(tbNome, errorProvider);
            validaNumero(tbNumero, errorProvider);
            validaEmail(tbEmail, errorProvider);


            if (CPF.valida(mbCpf.Text))
            {
                men = "CPF Valido";
            }

            else
            {

                men = "CPF Invalido";

            }

            MessageBox.Show(men, "Validação");

           
        }

        private void btSalvarCadVeiculo_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            validaPlacaCaracter(txtPlacaLetra, errorProvider);
            validaPlacaNum(txtPlacaNumero, errorProvider);
        }

        private void btSairCadVeiculo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLimparCadVeiculo_Click(object sender, EventArgs e)
        {
            txtPlacaLetra.Clear();
            txtPlacaNumero.Clear();
        }
    }
}
