using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCadastroAlunos
{
    public partial class FrmCadastro : Form
    {
        ListaSimples<Aluno> lista1;
        ListaSimples<Aluno> lista2;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            lista1 = new ListaSimples<Aluno>();   // instancia a lista ligada de alunos
        }

        private void FazerLeitura(ref ListaSimples<Aluno> qualLista, ListBox qualListBox)
        {
            qualLista = new ListaSimples<Aluno>(); // recria a lista a ser lida
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                string linha = "";
                while (!arquivo.EndOfStream)
                {
                    linha = arquivo.ReadLine();
                    qualLista.InserirAposFim(new Aluno(linha));
                }
                qualLista.Listar(qualListBox);
                arquivo.Close();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtRA.Text != "" && txtNome.Text != "")
            {
                var novoAluno = new Aluno(txtRA.Text, txtNome.Text, (double)nudNota.Value);
                lista1.InserirAposFim(novoAluno);
                lista1.Listar(lsbUm);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRA.Text))
            {
                MessageBox.Show("Informe o RA do aluno a ser procurado!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string raProcurado = txtRA.Text;
            bool alunoEncontrado = false;

            // Percorre a lista1 para encontrar o aluno
            lista1.atual = lista1.primeiro;

            while (lista1.atual != null)
            {
                if (lista1.atual.Info.Ra == raProcurado)
                {
                    // Preenche os campos com os dados do aluno encontrado
                    txtNome.Text = lista1.atual.Info.Nome;
                    nudNota.Value = (decimal)lista1.atual.Info.Nota;
                    alunoEncontrado = true;
                    break;
                }

                lista1.atual = lista1.atual.Prox;
            }

            if (!alunoEncontrado)
            {
                MessageBox.Show("Aluno não encontrado!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRA.Text))
            {
                MessageBox.Show("Informe o RA do aluno a ser excluído!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string raProcurado = txtRA.Text;
            bool alunoRemovido = false;

            // Percorre a lista1 para encontrar e remover o aluno
            lista1.atual = lista1.primeiro;
            lista1.anterior = null;

            while (lista1.atual != null)
            {
                if (lista1.atual.Info.Ra == raProcurado)
                {
                    // Remove o nó encontrado
                    if (lista1.anterior == null)
                    {
                        // Remove o primeiro nó
                        lista1.primeiro = lista1.atual.Prox;
                        if (lista1.primeiro == null)
                            lista1.ultimo = null;
                    }
                    else
                    {
                        lista1.anterior.Prox = lista1.atual.Prox;
                        if (lista1.atual.Prox == null)
                            lista1.ultimo = lista1.anterior;
                    }

                    lista1.quantosNos--;
                    alunoRemovido = true;
                    break;
                }

                lista1.anterior = lista1.atual;
                lista1.atual = lista1.atual.Prox;
            }

            if (alunoRemovido)
            {
                MessageBox.Show("Aluno removido com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lista1.Listar(lsbUm); // Atualiza a exibição na ListBox
            }
            else
            {
                MessageBox.Show("Aluno não encontrado!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLerArquivo1_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista1, lsbUm);
        }

        private void btnExe1_Click(object sender, EventArgs e)
        {
            int quantidade = lista1.ContarNos();
            MessageBox.Show($"A lista contém {quantidade} alunos.");
        }

        private void SepararParesImpares()
        {
            // Criar listas separadas
            ListaSimples<int> listaPares = new ListaSimples<int>();
            ListaSimples<int> listaImpares = new ListaSimples<int>();

            // Converter a lista genérica de alunos para uma lista de inteiros (exemplo: RA como critério)
            ListaSimples<int> listaNumeros = ConverterListaParaInt(lista1);

            // Percorrer a lista de números e separar pares e ímpares
            NoLista<int> atual = listaNumeros.primeiro;

            while (atual != null)
            {
                NoLista<int> proximo = atual.Prox; // Guarda a referência do próximo nó

                if (atual.Info % 2 == 0)  // Se for par, insere na lista de pares
                {
                    listaPares.InserirAposFim(atual.Info);
                }
                else  // Se for ímpar, insere na lista de ímpares
                {
                    listaImpares.InserirAposFim(atual.Info);
                }

                atual = proximo;   // Avança para o próximo nó
            }

            // Exibir os resultados nos ListBox
            listaPares.Listar(lsbDois);
            listaImpares.Listar(lsbTres);

            MessageBox.Show("A lista foi separada em pares e ímpares!");
        }

        private ListaSimples<int> ConverterListaParaInt(ListaSimples<Aluno> listaAlunos)
        {
            ListaSimples<int> listaNumeros = new ListaSimples<int>();

            NoLista<Aluno> atual = listaAlunos.primeiro;

            while (atual != null)
            {
                // Supondo que queremos separar os alunos pelo RA (convertendo para int)
                if (int.TryParse(atual.Info.Ra, out int numero))
                {
                    listaNumeros.InserirAposFim(numero);
                }

                atual = atual.Prox;
            }

            return listaNumeros;
        }


        private void btnExe2_Click(object sender, EventArgs e)
        {
            SepararParesImpares();
        }

        private void btnLerArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista2, lsbDois);
        }

        public static ListaSimples<int> MesclarListasOrdenadas(NoLista<int> primeiro1, NoLista<int> primeiro2)
        {
            ListaSimples<int> listaMesclada = new ListaSimples<int>();
            NoLista<int> atual1 = primeiro1;
            NoLista<int> atual2 = primeiro2;

            while (atual1 != null && atual2 != null)
            {
                if (atual1.Info == atual2.Info)
                {
                    // Evita repetição, insere apenas um e avança os dois
                    listaMesclada.InserirAposFim(atual1.Info);
                    atual1 = atual1.Prox;
                    atual2 = atual2.Prox;
                }
                else if (atual1.Info < atual2.Info)
                {
                    listaMesclada.InserirAposFim(atual1.Info);
                    atual1 = atual1.Prox;
                }
                else // atual1.Info > atual2.Info
                {
                    listaMesclada.InserirAposFim(atual2.Info);
                    atual2 = atual2.Prox;
                }
            }

            // Adiciona os elementos restantes da lista 1
            while (atual1 != null)
            {
                listaMesclada.InserirAposFim(atual1.Info);
                atual1 = atual1.Prox;
            }

            // Adiciona os elementos restantes da lista 2
            while (atual2 != null)
            {
                listaMesclada.InserirAposFim(atual2.Info);
                atual2 = atual2.Prox;
            }

            return listaMesclada;
        }

        private void btnExe3_Click(object sender, EventArgs e)
        {
            // Converter listas de alunos para listas de inteiros (supondo que usamos o RA)
            ListaSimples<int> listaNumeros1 = ConverterListaParaInt(lista1);
            ListaSimples<int> listaNumeros2 = ConverterListaParaInt(lista2); // Adicione a segunda lista

            // Chamar o método de mesclagem
            ListaSimples<int> listaMesclada = MesclarListasOrdenadas(listaNumeros1.primeiro, listaNumeros2.primeiro);

            // Exibir a nova lista mesclada
            listaMesclada.Listar(lsbTres); // lsbResultado é um ListBox na interface
        }

        private void btnExe4_Click(object sender, EventArgs e)
        {
            lista1.Inverter();
            lista1.Listar(lsbUm);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRA.Clear();
            txtNome.Clear();
            nudNota.Value = 0;
            lsbUm.Items.Clear();
            lsbDois.Items.Clear();
            lsbTres.Items.Clear();
        }
    }
}
