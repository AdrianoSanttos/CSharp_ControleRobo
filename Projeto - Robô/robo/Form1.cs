using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace robo
{
    public partial class Form1 : Form
    {
        DateTime DataAgora = new DateTime(); //Hora atual
        DateTime DataEncerra = new DateTime(); //Hora que irá encerrar o processo
        string Tarefa; //Objeto que recebe a tarefa
        int contadorExtracao; //objeto contador de extrações
        

        public Form1()
        {
            InitializeComponent();
            lblEstado.Text = "Estado: Pronto";
        }
      

        // Evento do Click do botão Andar
        private void Andar_Click(object sender, EventArgs e)
        {
                lblTarefa.Text = "Tarefa: Andar";
                Tarefa = "A";
                DataAgora = DateTime.Now;
                DataEncerra = DataAgora.AddSeconds(10);  //Adiciona 10 segundos ao tempo atual            
                timer1.Start();  //Inicia o timer              
                lblEstado.Text = "Estado: Ocupado ";
                
            
        }

        //Evento do Click do botão Procurar
        private void Procurar_Click(object sender, EventArgs e)
        {
            lblTarefa.Text = "Tarefa: Procurar";
            Tarefa = "P";
            DataAgora = DateTime.Now;
            DataEncerra = DataAgora.AddSeconds(25);  //Adiciona 25 segundos ao tempo atual        
            timer1.Start(); //Inicia o timer 

            lblEstado.Text = "Estado: Ocupado ";
        }

        //Evento do timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Verifica se a data de encerramento é maior que a hora atual
            if(DataEncerra > DateTime.Now)
            {
                lblEstado.Text = "Estado: Ocupado";
                btnAndar.Enabled = false;
                btnProcurar.Enabled = false;

            }
            else
            {
                //Verifica se a Tarefa é a Andar
                if (Tarefa.Equals("A"))
                {
                    timer1.Stop(); //Para o tempo do Timer
                    btnAndar.Enabled = true;
                    btnProcurar.Enabled = true;
                    lblTarefa.Text = "Tarefa:";
                    lblEstado.Text = "Estado: Pronto";
                }
                //Verifica se a Tarefa é a Procurar
                if(Tarefa.Equals("P"))
                {
                    timer1.Stop(); //Para o tempo do Timer
                    Random rand = new Random(); // Objeto Randomico
                    Double valor = rand.NextDouble();  //Gera um número randômico

                    //Verifica se o numero sorteado é maior que 0.5, deixando 50% de chance para maior ou menor
                    if (valor <= 0.5) 
                    {
                        btnAndar.Enabled = true;
                        btnProcurar.Enabled = true;
                        lblTarefa.Text = "Tarefa:";
                        lblEstado.Text = "Estado: Recuperando";
                    }
                    else
                    {
                        Extrair(); // Executa o método de extração
                    }
                }

                if(Tarefa.Equals("E"))
                {
                    if (contadorExtracao < 5)
                    {
                        timer1.Stop(); //Para o tempo do Timer
                        btnAndar.Enabled = true;
                        btnProcurar.Enabled = true;
                        lblTarefa.Text = "Tarefa:";
                        lblEstado.Text = "Estado: Recuperando";
                    }
                    else 
                    {
                        lblTarefa.Visible = false;                        
                        btnAndar.Enabled = false;
                        btnProcurar.Enabled = false;
                        lblEstado.Visible = false;
                        lblMsgSucesso.Visible = true;
                        
                    }
                }
            }
            
        }

        //Método que extrai o petróleo
        private void Extrair() 
        {
            if(contadorExtracao < 5)
            {
                lblTarefa.Text = "Tarefa: Extrair";
                Tarefa = "E";
                DataAgora = DateTime.Now;
                DataEncerra = DataAgora.AddSeconds(30); //Adiciona 30 segundos ao tempo atual   
                timer1.Start();
                contadorExtracao++; //Adiciona 1 ao contador
                lblEstado.Text = "Estado: Ocupado ";
            }            
            
        }
        

            
    }
}
