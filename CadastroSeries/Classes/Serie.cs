﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries
{
    class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        public bool Excluido { get; set; }



        public Serie(int id, Genero genero, string titulo, string descricao, int ano) 
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descricao: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano;
            return retorno;

        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

       
        public bool retornaExcluido()
        {
            return Excluido;
        }
        public void Excluir()
        {
            Excluido = true;
        }
    }

    
    
}
