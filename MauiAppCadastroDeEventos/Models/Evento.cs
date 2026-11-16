using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastroDeEventos.Models
{
    public class Evento
    {
        public string NomeEvento {  get; set; }
        public DateTime DataIni {  get; set; }
        public DateTime DataTerm { get; set; }
        public int QntPartic { get; set; }
        public string LocalEvento { get; set; }
        public int CustoPartic { get; set; }

        public int Duracao
        {
            get => DataTerm.Subtract(DataIni).Days;
        }

        public double ValorDiario
        {
            get
            {
                double total = QntPartic * CustoPartic;

                return total;
            }
        }
        public double ValorTotal
        {
            get
            {
                double total = ValorDiario * Duracao;

                return total;
            }
        }
    }
}
