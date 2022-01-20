﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo;
internal class Produto
{
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto() { }

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
                _nome = value;
        }
    }

    #region Properties
    //public double Preco
    //{
    //    get { return _preco; }
    //}

    //public int Quantidade
    //{
    //    get { return _quantidade; }
    //}
    #endregion

    #region ConstrutorEx
    //public Produto(string nome, double preco)
    //{
    //    Nome = nome;
    //    Preco = preco;
    //    Quantidade = 5;
    //}
    #endregion

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProduto(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

    }

}
