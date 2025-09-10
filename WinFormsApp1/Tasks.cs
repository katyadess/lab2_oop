using System;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public static class Tasks
    {
        public static string Task1(int[] a)
        {

            //1.Задано одновимірний масив розміром N. 
            //Визначити кількість від’ємних чисел, кількість додатних чисел та середнє арифметичне всіх чисел.

            int neg = a.Count(x => x < 0);
            int pos = a.Count(x => x > 0);
            double avg = a.Length > 0 ? a.Average() : 0;
            return $"Від’ємних чисел: {neg}, додатних чисел: {pos}, середнє: {avg:F2}";
        }

        public static string Task2(int[] a)
        {

            //2.Заданий одновимірний масив розміром N. 
            //Сформувати два масиву розміром N / 2, включаючи перший елементи вихідного масиву з парними індексами,
            //а в другий -з непарними.Обчислити суми елементів кожного з масивів.


            var first = a.Where((v, i) => i % 2 == 0).ToArray();
            var second = a.Where((v, i) => i % 2 == 1).ToArray();
            return $"Перший масив (парні індекси) [{string.Join(" ", first)}], сума={first.Sum()}\r\nДругий масив (непарні індекси) [{string.Join(" ", second)}], сума={second.Sum()}";
        }

        public static string Task3(int[] a)
        {
            //3.Визначити середнє арифметичне значення першого негативного та останнього позитивного елементів одновимірного масиву, 
            //розмір якого дорівнює М.

            int firstNeg = a.FirstOrDefault(x => x < 0);
            int lastPos = a.LastOrDefault(x => x > 0);
            bool foundFirstNeg = a.Any(x => x < 0);
            bool foundLastPos = a.Any(x => x > 0);
            if (!foundFirstNeg || !foundLastPos) return "Немає першого від’ємного або останнього додатнього елементу.";

            double avg = (firstNeg + lastPos) / 2.0;
            return $"Перший від’ємний елемент: {firstNeg}, останній додатній елемент: {lastPos}, середнє: {avg:F2}";
        }

        public static string Task4(int[] a)
        {
            //4.Визначити кількість від’ємних елементів, розміщених перед найбільшим додатним елементом одновимірного масиву, 
            //розмір якого дорівнює М.

            int maxPos = int.MinValue;
            int idxMaxPos = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] > maxPos) {
                    maxPos = a[i];
                    idxMaxPos = i;
                }
            }

            if (idxMaxPos == -1) return "Немає додатніх елементів.";
            int negCount = a.Take(idxMaxPos).Count(x => x < 0);
            return $"Найбільший додатній елемент: {maxPos} на позиції {idxMaxPos}, кількість від’ємних елементів перед ним: {negCount}";

        }

        public static string Task5(int[] a)
        {
            //5.У заданому одновимірному масиві розміром N поміняти місцями перший і останній додатні елементи.
            int[] b = (int[])a.Clone();
            int firstPosIdx = Array.FindIndex(b, x => x > 0);
            int lastPosIdx = Array.FindLastIndex(b, x => x > 0);
            if (firstPosIdx == -1 || lastPosIdx == -1 || firstPosIdx == lastPosIdx)
                return "Немає достатньо додатніх елементів для перестановки.";

            int tmp = b[firstPosIdx];
            b[firstPosIdx] = b[lastPosIdx];
            b[lastPosIdx] = tmp;
            return $"Масив після перестановки першого і останнього додатніх елементів:\r\n[{string.Join(" ", b)}]";
        }

        public static string Task6(int[] a)
        {
            //6.Написати програму для обчислення суми та середнього арифметичного значення всіх елементів заданого одновимірного масиву А, 
            //що складається з 10 елементів.

            if (a.Length != 10)
                return "Масив повинен містити рівно 10 елементів.";
            var sub = a.Take(10).ToArray();
            return $"Сума(перші 10)={sub.Sum()}, cереднє(перші 10)={sub.Average():F2}";
        }

        public static string Task7(int[] a)
        {
            //7.Написати програму для обчислення суми додатних елементів, 
            //заданого масиву А, що складається з 20 елементів.

            if (a.Length != 20)
                return "Масив повинен містити рівно 20 елементів.";

            var sub = a.Take(20).ToArray();
            int sumPos = sub.Where(x => x > 0).Sum();
            return $"Сума додатніх елементів (перші 20)={sumPos}";
        }

        public static string Task8(int[] a)
        {
            //8.Написати програму для обчислення суми парних елементів заданого масиву А, 
            //що складається з 20 елементів.

            if (a.Length != 20)
                return "Масив повинен містити рівно 20 елементів.";

            var sub = a.Take(20).ToArray();
            int sumEven = sub.Where(x => x % 2 == 0).Sum();
            return $"Сума парних елементів (перші 20)={sumEven}";

        }

        public static string Task9(int[] a)
        {
            //9.У заданому векторі(одномірному масиві) визначити: 
            //максимальний від’ємний і мінімальний додатній елементи.

            var negatives = a.Where(x => x < 0).ToArray();
            var positives = a.Where(x => x > 0).ToArray();
            if (!negatives.Any() && !positives.Any())
                return "Немає ні від’ємних ні додатніх елементів.";

            string neg = negatives.Any() ? negatives.Max().ToString() : "Немає від’ємних елементів.";
            string pos = positives.Any() ? positives.Min().ToString() : "Немає додатніх елементів.";
            return $"Максимальний від’ємний елемент: {neg}, мінімальний додатній елемент: {pos}";
        }

        public static string Task10(int[] a)
        {
            //10.Написати програму для визначення індексів додатних елементів, 
            //заданого масиву А, що складається з 20 елементів.

            if (a.Length != 20)
                return "Масив повинен містити рівно 20 елементів.";

            var sub = a.Take(20).ToArray();
            var indices = sub.Select((v, i) => new { v, i }).Where(x => x.v > 0).Select(x => x.i).ToArray();
            if (!indices.Any())
                return "Немає додатніх елементів серед перших 20.";
            return $"Індекси додатніх елементів (перші 20): {string.Join(" ", indices)}";
        }

        public static string Task11(int[] a)
        {
            //11.Написати програму для обчислення середнього арифметичного значення всіх елементів заданого масиву D.
            //Для від’ємних елементів використовувати абсолютні значення.

            double avg = a.Select(x => x < 0 ? Math.Abs(x) : x).Average();
            return $"Середнє арифметичне (з абсолютними значеннями для від’ємних) = {avg:F2}";

        }

        public static string Task12(int[] a)
        {

            //12.Написати програму для пошуку в заданому масиві В, що складається з 10 елементів, третього додатнього елемента та його індексу. 
            //Відомо, що хоча б один додатній елемент у масиві є.

            if (a.Length != 10)
                return "Масив повинен містити рівно 10 елементів.";

            var sub = a.Take(10).ToArray();
            var posElements = sub.Select((v, i) => new { v, i }).Where(x => x.v > 0).ToArray();
            if (posElements.Length < 3)
                return "Менше трьох додатніх елементів серед перших 10.";
            var third = posElements[2];
            return $"Третій додатній елемент: {third.v}, його індекс: {third.i}";

        }

        public static string Task13(int[] a)
        {
            //13.Написати програму пошуку в заданому масиві В, що складається з 20 елементів, 
            //третього додатнього елемента та його індексу.

            if (a.Length != 20)
                return "Масив повинен містити рівно 20 елементів.";

            var sub = a.Take(20).ToArray();
            var posElements = sub.Select((v, i) => new { v, i }).Where(x => x.v > 0).ToArray();
            if (posElements.Length < 3)
                return "Менше трьох додатніх елементів серед перших 20.";
            var third = posElements[2];
            return $"Третій додатній елемент: {third.v}, його індекс: {third.i}";

        }

        public static string Task14(int[] a)
        {

            //14.Написати програму для пошуку в заданому масиві А(15) 
            //найбільшого значення елемента та його індексу.

            if (a.Length != 15)
                return "Масив повинен містити рівно 15 елементів.";

            var sub = a.Take(15).ToArray();
            int max = sub.Max();
            int idx = Array.IndexOf(sub, max);
            return $"Найбільший елемент: {max}, його індекс: {idx}";

        }

        public static string Task15(int[] a)
        {
            //15.Написати програму, в якій проводиться перестановка парних та непарних елементів, 
            //заданого масиву С.
            int[] b = (int[])a.Clone();
            for (int i = 0; i + 1 < b.Length; i += 2)
            {
                int t = b[i];
                b[i] = b[i + 1];
                b[i + 1] = t;
            }
            return $"Масив після перестановки парних та непарних елементів:\r\n[{string.Join(" ", b)}]";

        }

        public static string Task16(int[] a)
        {
            //16.Для заданого масиву А, що складається не більше ніж з 50 елементів, 
            //знайти найменший елемент і переставити його з другим по порядку від’ємним елементом масиву.

            int minVal = a.Min();
            int minIdx = Array.IndexOf(a, minVal);
            var negIndices = a.Select((v, i) => new { v, i }).Where(x => x.v < 0).Select(x => x.i).ToArray();
            if (negIndices.Length < 2)
                return "Менше двох від’ємних елементів у масиві.";
            int secondNegIdx = negIndices[1];
            int[] b = (int[])a.Clone();
            int tmp = b[minIdx];
            b[minIdx] = b[secondNegIdx];
            b[secondNegIdx] = tmp;
            return $"Масив після перестановки найменшого елемента і другого від’ємного елемента:\r\n[{string.Join(" ", b)}]";

        }

        public static string Task17(int[] a)
        {
            //17.Написати програму з упорядкування елементів заданого масиву У такому порядку: 
            //спочатку йдуть додатні числа, потім -нулі і наприкінці -від’ємні.

            var positives = a.Where(x => x > 0);
            var zeros = a.Where(x => x == 0);
            var negatives = a.Where(x => x < 0);
            var sorted = positives.Concat(zeros).Concat(negatives).ToArray();
            return $"Масив після упорядкування (додатні, нулі, від’ємні):\r\n[{string.Join(" ", sorted)}]";

        }

        public static string Task18(int[] a)
        {
            //18.Написати програму сортування за зростанням заданого масиву В, 
            //що складається з 10 - ти елементів.

            if (a.Length != 10)
                return "Масив повинен містити рівно 10 елементів.";
            var sub = a.Take(10).ToArray();
            Array.Sort(sub);
            return $"Масив після сортування за зростанням (перші 10):\r\n[{string.Join(" ", sub)}]";

        }

        public static string Task19(int[] a)
        {
            //19.Написати програму.Для заданого масиву, що складається з 10 - ти елементів, 
            //змінити порядок слідування його елементів на зворотній.
            if (a.Length != 10)
                return "Масив повинен містити рівно 10 елементів.";
            var sub = a.Take(10).ToArray();
            Array.Reverse(sub);
            return $"Масив після зміни порядку слідування на зворотній (перші 10):\r\n[{string.Join(" ", sub)}]";

        }

        public static string Task20(int[] a)
        {

            //20.Написати програму, в якій для заданого масиву, що складається з 10 - ти елементів,
            //його елементи переміщалися б наприклад на 7 позицій вправо.
            //При цьому 7 елементів з кінця масиву переміщуються на початок

            if (a.Length != 10)
                return "Масив повинен містити рівно 10 елементів.";

            var sub = a.Take(10).ToArray();
            int shift = 7 % sub.Length;
            int[] b = new int[sub.Length];
            for (int i =0; i < a.Length; i++) 
                b[(i+shift) % a.Length] = sub[i];
            return $"Масив після зсуву на 7 позицій вправо (перші 10):\r\n[{string.Join(" ", b)}]";
        }

        public static string Task21(int[] a)
        {
            //21.Заданий масив А. Помістити додатні елементи цього масиву масив, 
            //а від’ємні елементи -масив З.

            var positives = a.Where(x => x > 0).ToArray();
            var negatives = a.Where(x => x < 0).ToArray();
            return $"Масив додатніх елементів:\r\n[{string.Join(" ", positives)}]\r\nМасив від’ємних елементів:\r\n[{string.Join(" ", negatives)}]";

        }

        public static string Task22(int[] a)
        {

            //22.У заданому векторі(одномірному масиві) знайти суму першого та останнього від’ємного елемента
            var negs = a.Select((v, i) => new { v, i }).Where(x => x.v < 0).ToArray();
            if (negs.Length == 0)
                return "Немає від’ємних елементів.";
            int sum = negs.First().v + negs.Last().v;
            return $"Перший від’ємний елемент: {negs.First().v}, останній від’ємний елемент: {negs.Last().v}, їх сума: {sum}";

        }

        public static string Task23(int[] a)
        {

            //23.У заданому векторі(одномірному масиві) знайти: різницю першого та останнього непарного елементів
            var odds = a.Select((v, i) => new { v, i }).Where(x => Math.Abs(x.v) % 2 != 0).ToArray();
            if (odds.Length == 0)
                return "Немає непарних елементів.";
            int diff = odds.First().v - odds.Last().v;
            return $"Перший непарний елемент: {odds.First().v}, останній непарний елемент: {odds.Last().v}, їх різниця: {diff}";
        }

        public static string Task24(int[] a)
        {
            //24.У заданому векторі(одномірному масиві) знайти: 
            //індекси найменшого та найбільшого з елементів

            int min = a.Min();
            int max = a.Max();
            int minIdx = Array.IndexOf(a, min);
            int maxIdx = Array.IndexOf(a, max);
            return $"Найменший елемент: {min} на позиції {minIdx}, найбільший елемент: {max} на позиції {maxIdx}";
        }

        public static string Task25(int[] a)
        {

            //25.У заданому векторі(одномірному масиві) знайти: добуток трьох найменших елементів вектора
            var smallest = a.OrderBy(x => x).Take(3).ToArray();
            long product = 1;
            foreach (var num in smallest)
                product *= num;
            return $"Три найменші елементи: {string.Join(" ", smallest)}, їх добуток: {product}";

        }

        public static string Task26(int[] a)
        {

            //26.У заданому векторі(одномірному масиві) знайти: суму елементів вектора з парними індексами
            int sum = a.Where((v, i) => i % 2 == 0).Sum();
            return $"Сума елементів з парними індексами: {sum}";

        }

        public static string Task27(int[] a)
        {
            //27.У заданому векторі(одномірному масиві) знайти: різницю першого додатнього та останнього від’ємного елемента
            var firstPos = a.Select((v, i) => new { v, i }).FirstOrDefault(x => x.v > 0);
            var lastNeg = a.Select((v, i) => new { v, i }).LastOrDefault(x => x.v < 0);
            if (firstPos == null || lastNeg == null)
                return "Немає першого додатнього або останнього від’ємного елементу.";
            int diff = firstPos.v - lastNeg.v;
            return $"Перший додатній елемент: {firstPos.v}, останній від’ємний елемент: {lastNeg.v}, їх різниця: {diff}";


        }

        public static string Task28(int[] a)
        {
            //28.У заданому векторі(одномірному масиві) знайти: кількість негативних елементів з непарними індексами
            int count = a.Where((v, i) => i % 2 == 1 && v < 0).Count();
            return $"Кількість від’ємних елементів з непарними індексами: {count}";

        }

        public static string Task29(int[] a)
        {
            //29.У заданому векторі(одномірному масиві) знайти: число елементів, розташованих після найбільшого від’ємного елемента.
            var negatives = a.Select((v, i) => new { v, i }).Where(x => x.v < 0).ToArray();
            if (negatives.Length == 0)
                return "Немає від’ємних елементів.";
            var maxNeg = negatives.OrderByDescending(x => x.v).First();
            int countAfter = a.Length - maxNeg.i - 1;
            return $"Найбільший від’ємний елемент: {maxNeg.v} на позиції {maxNeg.i}, кількість елементів після нього: {countAfter}";

        }

        public static string Task30(int[] a)
        {
            //30.Написати програму для визначення кількості додатних елементів, заданого масиву А, що складається з 20 елементів.
            if (a.Length != 20)
                return "Масив повинен містити рівно 20 елементів.";
            var sub = a.Take(20).ToArray();
            int countPos = sub.Count(x => x > 0);
            return $"Кількість додатніх елементів (перші 20)={countPos}";


        }


    }
}
