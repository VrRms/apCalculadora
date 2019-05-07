using System;

/// <summary>
/// NOMES: MATEUS DE PADUA VICENTE E VITOR RAMOS
/// RAs  : 18186 E 18171
/// </summary>

public interface IStack<Dado> where Dado : IComparable<Dado>
{
    void Empilhar(Dado elemento);
    Dado Desempilhar();
    Dado OTopo();
    bool EstaVazia();
    int Tamanho();
}
