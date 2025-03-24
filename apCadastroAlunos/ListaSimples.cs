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

        if (EstaVazia)          // se a lista está vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o último nós!
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
        oListBox.Items.Clear();    // limpa o conteúdo do listbox
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
            NoLista<Dado> proximo = atual.Prox; // Guarda a referência do próximo nó

            // Converte para Int64 para verificar par/ímpar
            long valor = Convert.ToInt64(atual.Info);

            if (valor % 2 == 0)  // Se for par, insere na lista de pares
            {
                if (listaPares.ultimo != null)
                    listaPares.ultimo.Prox = atual;
                else
                    listaPares.primeiro = atual;

                listaPares.ultimo = atual;
            }
            else  // Se for ímpar, insere na lista de ímpares
            {
                if (listaImpares.ultimo != null)
                    listaImpares.ultimo.Prox = atual;
                else
                    listaImpares.primeiro = atual;

                listaImpares.ultimo = atual;
            }

            atual.Prox = null; // Remove o vínculo com a lista original
            atual = proximo;   // Avança para o próximo nó
        }

        // Atualiza a quantidade de nós das listas separadas
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
            proximo = atual.Prox;  // Armazena o próximo nó
            atual.Prox = anterior; // Inverte a ligação do nó atual
            anterior = atual;      // Move "anterior" para o nó atual
            atual = proximo;       // Move "atual" para o próximo nó
        }

        // Atualiza os ponteiros da lista
        ultimo = primeiro;
        primeiro = anterior;
    }
}