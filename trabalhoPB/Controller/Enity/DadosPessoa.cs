using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trabalhoPB
{
    class DadosPessoa
    {
        //private
        private String ID;
        private String nome;
        private String data;
        private String mae;
        private String pai;
        private String telefone;
        private String cep;

        public DadosPessoa()
        {
            ID = string.Empty;
            nome = string.Empty; //retorna uma matriz vazia.
            data = string.Empty;
            mae = string.Empty;
            pai = string.Empty;
            telefone = string.Empty;
            cep = string.Empty;

        }

        public DadosPessoa(String Id,String Nome, String Data, String Mae, String Pai, String Tell, String Cep)
        {
            ID = Id;
            NOME = Nome;
            DATA = Data;
            MAE = Mae;
            PAI = Pai;
            TELEFONE = Tell;
            CEP = Cep;
        }

        // public + get's e set's
        public String id
        {
            get { return this.ID; }//obtendo dados
            set { this.ID = value; }
        }

        public String NOME
        {
            get { return this.nome; }//obtendo dados
            set { this.nome = value; }
        }

        public String DATA
        {
            get { return this.data; }
            set { this.data = value; }
        }


        public String MAE
        {
            get { return this.mae; }
            set { this.mae = value; }
        }

        public String PAI
        {
            get { return this.pai; }
            set { this.pai = value; }
        }


        public String TELEFONE
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }

        public String CEP
        {
            get { return this.cep; }
            set { this.cep = value; }
        }

    }
}
