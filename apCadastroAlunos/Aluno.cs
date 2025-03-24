using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluno : IComparable<Aluno>
{
    // mapeamento dos campos do registro do arquivo texto
    const int tamanhoRA = 5;
    const int tamanhoNome = 30;
    const int tamanhoNota = 4;
    const int inicioRA = 0;
    const int inicioNome = inicioRA + tamanhoRA;
    const int inicioNota = inicioNome + tamanhoNome;

    string ra,
        nome;    // nota é de tipo string
    double nota;

    public string Ra // propriedade
    {
        get => ra;
        set
        {
            if (value != "")
                ra = value.Substring(0, tamanhoRA).PadLeft(tamanhoRA, '0');
            else
                throw new Exception("RA vazio é inválido");
        }
    }

    public string Nome // propriedade
    {
        get => nome;
        //set => nome = value.Substring(0, tamanhoNome).PadRight(tamanhoNome, '0');
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Nome não pode ser vazio.");

            // Garante que a string tem pelo menos tamanhoNome caracteres antes de usar Substring
            value = value.PadRight(tamanhoNome, ' ');
            nome = value.Substring(0, tamanhoNome);
        }
    }

    public double Nota // propriedade
    {
        get => nota;
        set
        {
            if (value < 0 || value > 10)
                throw new Exception("Nota inválida!");
            nota = value;
        }
    }

    // construtor
    public Aluno(string linhaDeDados)    // string lida do arquivo texto
    {
        Ra = linhaDeDados.Substring(inicioRA, tamanhoRA);
        Nome = linhaDeDados.Substring(inicioNome, tamanhoNome);
        Nota = double.Parse(linhaDeDados.Substring(inicioNota, tamanhoNota));
    }
    public Aluno(string ra, string nome, double nota)
    {
        Ra = ra;
        Nome = nome;
        Nota = nota;
    }
    public int CompareTo(Aluno outroAluno)
    {
        return ra.CompareTo(outroAluno.ra);
    }
    public override string ToString()
    {
        return ra + " " + nome + " " + nota;
    }


}