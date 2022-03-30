using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataInformanda;
            DateTime diaAtual = DateTime.Now;
            int ContDia = 0, contMeses = 0, ContSemanas = 0, contAno = 0;


            Console.WriteLine("Informe uma data: ");
            dataInformanda = Convert.ToDateTime(Console.ReadLine());


            TimeSpan periodoTempo = diaAtual - dataInformanda;

            int diferencadias = periodoTempo.Days;

            quantidadeTempo(ref ContDia, ref contMeses, ref ContSemanas, ref contAno, ref diferencadias);

            Escrever(ContDia, contMeses, ContSemanas, contAno);

        }

        private static void quantidadeTempo(ref int ContDia, ref int contMeses, ref int ContSemanas, ref int contAno, ref int diferencadias)
        {
            do
            {
                if (diferencadias >= 365)
                {
                    diferencadias = diferencadias - 365;
                    contAno++;
                }
            } while (diferencadias > 365);

            do
            {
                if (diferencadias >= 30)
                {
                    diferencadias = diferencadias - 30;
                    contMeses++;
                }

            } while (diferencadias > 30);
            do
            {
                if (diferencadias >= 7)
                {
                    diferencadias = diferencadias - 7;
                    ContSemanas++;
                }
            } while (diferencadias > 7);
            do
            {
                if (diferencadias < 7)
                {
                    diferencadias = diferencadias - 1;
                    ContDia++;
                }
            } while (diferencadias == 1);
        }

        private static void Escrever(int ContDia, int contMeses, int ContSemanas, int contAno)
        {
            if (contAno != 0)
            {
                string ano = contAno.ToString();
                if (contAno == 1)
                    Console.Write(ano + " Ano ");
                else Console.Write(ano + " Anos ");
            }
            if (contMeses != 0)
            {
                string mes = contMeses.ToString();
                if (contMeses == 1)
                    Console.Write(mes + " mes ");
                else Console.Write(mes + " meses ");
            }
            if (ContSemanas != 0)
            {
                string semana = ContSemanas.ToString();
                if (ContSemanas == 1)
                    Console.Write(semana + " semana ");
                else Console.Write(semana + " semanas ");
            }
            if (ContDia != 0)
            {
                string dia = ContDia.ToString();
                if (ContDia == 1)
                    Console.Write(dia + " dia ");
                else Console.Write(dia + " dias ");
            }
        }
    }
}
