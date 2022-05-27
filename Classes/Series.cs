using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulasDio.Enums;

namespace AulasDio.Classes
{
    public class Series : BaseEntities
    {
        public Genero Genero { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public Series(int id,Genero genero, string? titulo, string? descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo=titulo;
            this.Descricao=descricao;
            this.Ano=ano;
            this.Excluido=false;
        }

        public override string  ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {   
            return "Numero de cadastro: " + this.Id + Environment.NewLine +
                   "Titulo da Série: " + this.Titulo + Environment.NewLine;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void RetornaExcluido()
        {
            this.Excluido = true;
        }


        public string  RetornaSerie()
        {
            
                string retorno = "";
                retorno += "Gênero: " + this.Genero + Environment.NewLine;
                retorno += "Título: " + this.Titulo + Environment.NewLine;
                retorno += "Descrição: " + this.Descricao + Environment.NewLine;
                retorno += "Ano de início: " + this.Ano + Environment.NewLine;
                return retorno;
            
        }
        public void Excluir()
        {
            this.Excluido = true;
        }



    }


}
