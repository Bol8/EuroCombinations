using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations.POCO;
using StringExtensions;

namespace EuroCombinations.Manage
{
    public class CombinationAnalyze
    {
        private int AsociationType;

        public int Range1 { get; private set; }
        public int Range2 { get; private set; }
        public int Range3 { get; private set; }
        public int Range4 { get; private set; }
        public int Range5 { get; private set; }

        public int Pares { get; private set; }
        public int Impares { get; private set; }

        public int Tiradas { get; private set; }

        private readonly int CombinationLength;
        public int Combinations { get; private set; }
        public int NumCombinationsInf { get; private set; }
        public int NumbCombinationsInfPercent { get; private set; }
        private int Limit;

        public List<List<string>> CombinacionesCoincidentes { get; private set; }

        public string Combination { get; private set; }

        public List<Combination> combinationList;
        private List<Combination> WinCombinationList;


        public CombinationAnalyze(int asociationType, int combinationLength)
        {
            combinationList = new List<Combination>();
            AsociationType = asociationType;
            CombinationLength = combinationLength;

            initValues();
        }


        public CombinationAnalyze(int asociationType, int combinationLength, List<List<string>> combinations)
        {
            combinationList = new List<Combination>();
            WinCombinationList = new List<Combination>();

            AsociationType = asociationType;
            CombinationLength = combinationLength;
            obtenerCombinacionGanadora(combinations);

            initValues();
        }

        private void initValues()
        {
            Limit = CombinationLength - AsociationType;
            var a = Factorial(CombinationLength);

            Limit = 1;
            var b = Factorial(AsociationType);

            Combinations = a / b;
        }


        private int Factorial(int i)
        {
            if (i <= Limit) return 1;

            return i * Factorial(i - 1);
        }


        public void parAnalyze(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    parCounter(number);
                }
            }
        }

        private void parCounter(string number)
        {
            int num;

            if (int.TryParse(number, out num))
            {
                if (isPar(num)) Pares++;
                else Impares++;
            }
        }

        private void parCounter(int number)
        {
            if (isPar(number)) Pares++;
            else Impares++;
        }

        private bool isPar(int number)
        {
            return number % 2 == 0;
        }

        public void rangeAnalyze(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    rangeCounter(number);
                }
            }
        }

        public void rangeAnalyze1(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    int num;

                    if (!int.TryParse(number, out num)) continue;
                    if (num >= 1 && num <= 10) parCounter(num);
                }
            }
        }

        public void rangeAnalyze2(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    int num;

                    if (!int.TryParse(number, out num)) continue;
                    if (num > 10 && num <= 20) parCounter(num);
                }
            }
        }

        public void rangeAnalyze3(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    int num;

                    if (!int.TryParse(number, out num)) continue;
                    if (num > 20 && num <= 30) parCounter(num);
                }
            }
        }

        public void rangeAnalyze4(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    int num;

                    if (!int.TryParse(number, out num)) continue;
                    if (num > 30 && num <= 40) parCounter(num);
                }
            }
        }

        public void rangeAnalyze5(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                foreach (string number in combination)
                {
                    int num;

                    if (!int.TryParse(number, out num)) continue;
                    if (num > 40) parCounter(num);
                }
            }
        }

        private void rangeCounter(string number)
        {
            int num;

            if (int.TryParse(number, out num))
            {
                if (num >= 1 && num <= 10) Range1++;
                if (num > 10 && num <= 20) Range2++;
                if (num > 20 && num <= 30) Range3++;
                if (num > 30 && num <= 40) Range4++;
                if (num > 40) Range5++;
            }
        }

        public void combinationsAnalyze(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                var list = new List<string>();
                var cont = AsociationType;

                for (int i = combination.Count - 1; i >= 0; i--)
                {
                    var a = combination[i];

                    for (int j = combination.Count - cont++; j >= 0; j--)
                    {
                        var b = combination[j];

                        list.Add(a + "," + b);
                    }
                }

                if (list.Count != Combinations)
                {
                    throw new Exception("No se ha podido extraer todas las posibles combinaciones");
                }

                extraerValores(list);
            }
        }


        public void combinationsAnalyze3(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                var list = new List<string>();
                var cont = AsociationType;

                for (int i = combination.Count - 1; i >= 0; i--)
                {
                    var a = combination[i];

                    for (int j = i - 1; j >= 0; j--)
                    {
                        var b = combination[j];

                        for (int k = j - 1; k >= 0; k--)
                        {
                            var c = combination[k];

                            list.Add(a + "," + b + "," + c);
                        }
                    }
                }

                if (list.Count != Combinations)
                {
                    throw new Exception("No se ha podido extraer todas las posibles combinaciones");
                }

                extraerValores(list);
            }
        }


        public void combinationsAnalyze4(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                var list = new List<string>();
                var cont = AsociationType;

                for (int i = combination.Count - 1; i >= 0; i--)
                {
                    var a = combination[i];

                    for (int j = i - 1; j >= 0; j--)
                    {
                        var b = combination[j];

                        for (int k = j - 1; k >= 0; k--)
                        {
                            var c = combination[k];

                            for (int l = k - 1; l >= 0; l--)
                            {
                                var d = combination[l];

                                list.Add(a + "," + b + "," + c + "," + d);
                            }
                        }
                    }
                }

                if (list.Count != Combinations)
                {
                    throw new Exception("No se ha podido extraer todas las posibles combinaciones");
                }

                extraerValores(list);
            }

            calcularCombinacion();
        }

        private void calcularCombinacion()
        {
            do
            {
                Combination = generateCombination(5);
                Tiradas++;

            } while (!combinationList.Exists(x => x.Number.Equals(Combination)));
        }

        public void obtenerCombinacionGanadora(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                var list = new List<string>();
                var cont = AsociationType;

                list.Add(string.Join(",", combination));


                extraerValores(list);
            }

            calcularCombinacion();
        }

        public void obtenerCombinacionPorDistanciaDeNumeros(List<List<string>> combinations, int numero1, int numero2)
        {
            CombinacionesCoincidentes = new List<List<string>>();

            foreach (var combination in combinations)
            {
                if (recontarNumerosPorDistancia(combination, numero1, numero2))
                {
                    NumCombinationsInf++;
                    CombinacionesCoincidentes.Add(combination);
                }
            }

            NumbCombinationsInfPercent = NumCombinationsInf * 100 / combinations.Count;
        }


        private bool recontarNumerosPorDistancia(List<string> combination, int totalNumeros, int distancia )
        {
            var correcto = true;

            for (int i = 0; i < totalNumeros - 1 ; i++)
            {
                   if((int.Parse(combination[i + 1]) - int.Parse(combination[i]) > distancia )) correcto = false;
            }

            return correcto;
        }


        public void obtenerCombinacionQueEmpiezaEntreDosNumerps(List<List<string>> combinations, int numero1, int numero2)
        {
            foreach (var combination in combinations)
            {
                recontarCombinacionesQueEmpiezanEntreDosNumeros(int.Parse(combination[0]), numero1,numero2);
            }

            NumbCombinationsInfPercent = NumCombinationsInf * 100 / combinations.Count;
        }

        private void recontarCombinacionesQueEmpiezanEntreDosNumeros(int numero, int numero1,int numero2)
        {
            if (numero1 <= numero && numero2 >= numero) NumCombinationsInf++;
        }


        public void obtenerCombinacionQueEmpiezaPorUnNumeroInferior(List<List<string>> combinations, int numero)
        {
            foreach (var combination in combinations)
            {
                recontarCombinacionesQueEmpiezanPorUnNumeroInferior(int.Parse(combination[0]), numero);
            }

            NumbCombinationsInfPercent = NumCombinationsInf * 100 / combinations.Count;
        }

        private void recontarCombinacionesQueEmpiezanPorUnNumeroInferior(int numero, int numeroReferencia)
        {
            if (numero <= numeroReferencia) NumCombinationsInf++;
        }


        private void extraerValores(List<string> list)
        {
            foreach (var comb in list)
            {
                if (repetitionExists(comb))
                {
                    var com = combinationList.FirstOrDefault(x => x.Number.Equals(comb));
                    if (com != null) com.Repetitions++;
                }
                else
                {
                    var combination = new Combination() { Number = comb, Repetitions = 1 };
                    combinationList.Add(combination);
                }
            }
        }

        private bool repetitionExists(string comb)
        {
            return combinationList.Exists(x => x.Number.Equals(comb));
        }


        private string finalizeCombination(string numbers)
        {
            bool isOk = false;
            Random rnd = new Random();
            var numClone = "";
            var values = numbers.Split(',').ToList();

            while (!isOk)
            {
                var num = rnd.Next(1, 51).ToString();
                if (!values.Exists(x => Equals(x, num)))
                {
                    numClone = numbers + "," + num;
                    isOk = true;
                }
            }

            return numClone;
        }

        private string generateCombination(int length)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();

            while (numbers.Count < length)
            {
                var num = rnd.Next(1, 51);
                if (!numbers.Exists(x => x == num))
                {
                    numbers.Add(num);
                }
            }

            return formatearCombinacion(numbers.OrderBy(x => x).ToList());
        }


        private string formatearCombinacion(List<int> combinacion)
        {
            List<string> strCombinacion = new List<string>();

            foreach (var numero in combinacion)
            {
                strCombinacion.Add(numero < 10 ? numero.ToString().JoinUpStart("0") : numero.ToString());
            }


            return string.Join(",", strCombinacion);
        }

    }
}
