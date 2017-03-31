using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations.Manage;
using EuroCombinations.POCO;
using FileDownloader = FileDownloader.Core.FileDownloader;

namespace EuroCombinations
{
    class Program
    {
        const string filePath = @"C:\Users\Oscar\Documents\Ficheros\Euromillones\Historico.csv";
        const string pathLocalResource = @"C:\Users\Oscar\Documents\Ficheros\Euromillones\";

        static void Main(string[] args)
        {
            menuPrincipal();

            //var combAnalyze = new CombinationAnalyze(5,5);
            //combAnalyze.obtenerCombinacionGanadora(combinations);
            //combAnalyze.rangeAnalyze(combinations);
            //combAnalyze.rangeAnalyze3(combinations);

            //var orderList = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).ToList();

            //var comb = combAnalyze.combinationList.Where(x => x.Number.Equals("43,32,38,25"));

            //var total = combAnalyze.combinationList.Sum(x => x.Repetitions);

            //  var maxRep = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).Take(1).FirstOrDefault();

        }




        private static void menuPrincipal()
        {
            var salir = false;

            do
            {
                var option = mostrarMenu();

                switch (option)
                {
                    case "0":
                        actualizarFichero();
                        break;


                    case "1":
                        verCombinacionesGanadoras();
                        break;

                    case "2":
                        generarCombinacionGanadora();
                        break;

                    case "3":
                        obtenerNumeroCombinacionesQueEmpiezanPorUnNumeroInferior();
                        break;

                    case "4":
                        obtenerNumeroCombinacionesQueEmpiezanEntreDosNumerosDados();
                        break;

                    case "5":
                        obtenerNumeroCombinacionesPorDistanciaDeNumeros();
                        break;

                    case "6":
                        verSumaDeCombinacionesGanadoras();
                        break;


                    case "8":
                        salir = true;
                        break;
                }

            } while (!salir);

        }


        private static string mostrarMenu()
        {
            Console.WriteLine("Bienvenido.");
            Console.WriteLine("Selecciona una de las siguientes opciones");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("0- Actualizar fichero.");
            Console.WriteLine("1- Ver las combinaciones ganadoras.");
            Console.WriteLine("2- Generar combinación que coincida con alguna ganadora.");
            Console.WriteLine("3- Obtener número combinaciones que empiezan por un número inferiror al indicado.");
            Console.WriteLine("4- Obtener número de combinaciones que empiezan entre dos números dados.");
            Console.WriteLine("5- Obtener número de combinaciones donde la distancia entre números se inferior a la indicada.");
            Console.WriteLine("6- Ver a suma de las combinaciones ganadoras.");
            Console.WriteLine("8- Salir");

            return Console.ReadLine();
        }


        private static void verCombinacionesGanadoras()
        {
            var combinaciones = obtenerCombinacionesDelFichero();

            foreach (var combinacion in combinaciones)
            {
                Console.WriteLine(string.Join(",", combinacion));
            }

            Console.WriteLine("Total: " + combinaciones.Count + " combinaciones");
            Console.WriteLine("\n");
        }

        private static void verSumaDeCombinacionesGanadoras()
        {
            var combinaciones = obtenerCombinacionesDelFichero();

            foreach (var combinacion in combinaciones)
            {
                Console.WriteLine(sumaCombinacion(combinacion));
            }

            Console.WriteLine("Total: " + combinaciones.Count + " combinaciones");
            Console.WriteLine("\n");
        }

        private static int sumaCombinacion(List<string> combinacion)
        {
            var result = 0;

            foreach (var sNum in combinacion)
            {
                result += int.Parse(sNum);
            }

            return result;
        }

        private static void generarCombinacionGanadora()
        {
            Console.WriteLine("Generando.......");

            var combAnalyze = new CombinationAnalyze(5, 5);
            combAnalyze.obtenerCombinacionGanadora(obtenerCombinacionesDelFichero());

            Console.WriteLine("Combinación: " + combAnalyze.Combination);
            Console.WriteLine("Tiradas: " + combAnalyze.Tiradas);
            Console.WriteLine("\n");
        }

        private static void obtenerNumeroCombinacionesQueEmpiezanPorUnNumeroInferior()
        {
            var isOk = true;
            string numero;
            do
            {
                Console.WriteLine("Indique un número");
                numero = Console.ReadLine();

                var numAux = 0;
                isOk = int.TryParse(numero, out numAux);

                if (!isOk) Console.WriteLine("Por favor, indique un número");

            } while (!isOk);

            var combAnalyze = new CombinationAnalyze(5, 5);
            if (numero != null)
                combAnalyze.obtenerCombinacionQueEmpiezaPorUnNumeroInferior(obtenerCombinacionesDelFichero(), int.Parse(numero));

            Console.WriteLine("Número de combinaciones: " + combAnalyze.NumCombinationsInf);
            Console.WriteLine("Porcentaje: " + combAnalyze.NumbCombinationsInfPercent + "%");
            Console.WriteLine("\n");
        }

        private static void obtenerNumeroCombinacionesQueEmpiezanEntreDosNumerosDados()
        {
            var isOk = true;
            string numero1;
            string numero2;

            do
            {
                Console.WriteLine("Indique el primer número");
                numero1 = Console.ReadLine();

                Console.WriteLine("Indique el segundo número");
                numero2 = Console.ReadLine();

                var numAux = 0;
                isOk = int.TryParse(numero1, out numAux);
                isOk = int.TryParse(numero2, out numAux);

                if (!isOk) Console.WriteLine("Por favor, indique bien los números");

            } while (!isOk);

            var combAnalyze = new CombinationAnalyze(5, 5);
            if (numero1 != null && numero2 != null)
                combAnalyze.obtenerCombinacionQueEmpiezaEntreDosNumerps(obtenerCombinacionesDelFichero(), int.Parse(numero1), int.Parse(numero2));

            Console.WriteLine("Número de combinaciones: " + combAnalyze.NumCombinationsInf);
            Console.WriteLine("Porcentaje: " + combAnalyze.NumbCombinationsInfPercent + "%");
            Console.WriteLine("\n");
        }


        private static void obtenerNumeroCombinacionesPorDistanciaDeNumeros()
        {
            var isOk = true;
            string numero1;
            string numero2;

            do
            {
                Console.WriteLine("Indique números a controlar");
                numero1 = Console.ReadLine();

                Console.WriteLine("Indique distancia");
                numero2 = Console.ReadLine();

                var numAux = 0;
                isOk = int.TryParse(numero1, out numAux);
                isOk = int.TryParse(numero2, out numAux);

                if (!isOk) Console.WriteLine("Por favor, indique bien los números");

            } while (!isOk);

            var combAnalyze = new CombinationAnalyze(5, 5);
            if (numero1 != null && numero2 != null)
                combAnalyze.obtenerCombinacionPorDistanciaDeNumeros(obtenerCombinacionesDelFichero(), int.Parse(numero1), int.Parse(numero2));

          
            Console.WriteLine("Combinaciones:");
            foreach (var comb in combAnalyze.CombinacionesCoincidentes)
            {
                Console.WriteLine(string.Join(",", comb));
            }

            Console.WriteLine("Número de combinaciones: " + combAnalyze.NumCombinationsInf);
            Console.WriteLine("Porcentaje: " + combAnalyze.NumbCombinationsInfPercent + "%");
            Console.WriteLine("\n");
        }


        private static List<List<string>> obtenerCombinacionesDelFichero()
        {
            var combinations = new List<List<string>>();

            var lines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(',');
                var list = new List<string> { numbers[1], numbers[2], numbers[3], numbers[4], numbers[5] };
                combinations.Add(list);
            }

            return combinations;
        }

        private static void actualizarFichero()
        {
            var remoteUri =
                "https://docs.google.com/spreadsheet/pub?key=0AhqMeY8ZOrNKdEFUQ3VaTHVpU29UZ3l4emFQaVZub3c&output=csv";

            var fileDownloader = new global::FileDownloader.Core.FileDownloader();
            fileDownloader.DownloadFile(remoteUri, pathLocalResource, "Historico.csv");

        }

    }
}
