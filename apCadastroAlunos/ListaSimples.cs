using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>
{
    public NoLista<Dado> primeiro, ultimo, atual, anterior;      // antes sem 'public'

    public int quantosNos;      // antes sem 'public'

    public ListaSimples()
    {
        primeiro = ultimo = null;
        quantosNos = 0;
    }

    public bool EstaVazia
    {
        get => primeiro == null;

        // get 
        // {
        //    if (primeiro == null)
        //       return true;
        //    return false;
        // }
    }
    public void InserirAposFim(Dado novoDado)
    {
        NoLista<Dado> novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;


        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)          // se a lista est� vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o �ltimo n�s!
        else
            novoNo.Prox = primeiro;

        primeiro = novoNo;
        quantosNos++;
    }

    public void ExibirNaTela()
    {
        atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine(atual.Info);
            atual = atual.Prox;
        }
    }

    public void Listar(ListBox oListBox)
    {
        oListBox.Items.Clear();    // limpa o conte�do do listbox
        atual = primeiro;
        while (atual != null)
        {
            oListBox.Items.Add(atual.Info);
            atual = atual.Prox;
        }
    }

    public int ContarNos()
    {
        int contador = 0;
        atual = primeiro;

        while (atual != null)
        {
            contador++;
            atual = atual.Prox;
        }

        return contador;
    }

    private void AtualizarQuantidadeNos()
    {
        quantosNos = 0;
        atual = primeiro;
        while (atual != null)
        {
            quantosNos++;
            atual = atual.Prox;
        }
    }

    public void SepararParesImpares(out ListaSimples<Dado> listaPares, out ListaSimples<Dado> listaImpares)
    {
        listaPares = new ListaSimples<Dado>();
        listaImpares = new ListaSimples<Dado>();

        atual = primeiro;
        while (atual != null)
        {
            NoLista<Dado> proximo = atual.Prox; // Guarda a refer�ncia do pr�ximo n�

            // Converte para Int64 para verificar par/�mpar
            long valor = Convert.ToInt64(atual.Info);

            if (valor % 2 == 0)  // Se for par, insere na lista de pares
            {
                if (listaPares.ultimo != null)
                    listaPares.ultimo.Prox = atual;
                else
                    listaPares.primeiro = atual;

                listaPares.ultimo = atual;
            }
            else  // Se for �mpar, insere na lista de �mpares
            {
                if (listaImpares.ultimo != null)
                    listaImpares.ultimo.Prox = atual;
                else
                    listaImpares.primeiro = atual;

                listaImpares.ultimo = atual;
            }

            atual.Prox = null; // Remove o v�nculo com a lista original
            atual = proximo;   // Avan�a para o pr�ximo n�
        }

        // Atualiza a quantidade de n�s das listas separadas
        listaPares.AtualizarQuantidadeNos();
        listaImpares.AtualizarQuantidadeNos();

        // Esvazia a lista original
        primeiro = ultimo = null;
        quantosNos = 0;
    }

    public void Inverter()
    {
        NoLista<Dado> anterior = null;
        NoLista<Dado> atual = primeiro;
        NoLista<Dado> proximo = null;

        while (atual != null)
        {
            proximo = atual.Prox;  // Armazena o pr�ximo n�
            atual.Prox = anterior; // Inverte a liga��o do n� atual
            anterior = atual;      // Move "anterior" para o n� atual
            atual = proximo;       // Move "atual" para o pr�ximo n�
        }

        // Atualiza os ponteiros da lista
        ultimo = primeiro;
        primeiro = anterior;
    }
}