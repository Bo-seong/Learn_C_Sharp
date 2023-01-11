using System;
using System.Net.Sockets;

namespace MoreOnArray
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            // Sort() 
            // 배열을 정렬
            Array.Sort(scores);

            // ForEach() 
            // 모든 배열 요소에 대해 동일한 작업을 수행하게 합니다.
            Array.ForEach<int>(scores, new Action<int>(Print)); 
            Console.WriteLine();

            // Rank() 
            // 배열의 차원을 반환합니다.
            Console.WriteLine($"Number of dimensions : {scores.Rank}"); 

            // IndexOf()
            // 찾고자 하는 특정 인덱스를 반환
            Console.WriteLine($"Linear Search : 81 is at" +
                $"{Array.IndexOf(scores, 81)}"); 

            Console.WriteLine($"Linear Search : 90 is at" +
                $"{Array.IndexOf(scores, 90)}");

            // TrueForAll<T>()
            // 배열의 모든 요소가 지정한 조건에 부합하는지의 여부를 반환
            // 배열과 함께 조건을 검사하는 메소드를 매개변수로 받음.
            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}"); 

            // FindIndex<T>()
            // 배열에서 지정한 조건에 부합하는 첫 번째 요소의 인덱스를 반환
            // IndexOf() 메소드가 특정 값을 찾는데 비해, FindIndex<T>() 메소드는 지정한 조건에 바탕하여 값을 찾음.
            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            // GetLength()
            // 배열에서 지정한 차원의 길이를 반환
            Console.WriteLine("Old length of scores : " +
                $"{scores.GetLength(0)}");

            // Resize<T>()
            // 배열의 크기를 재조정
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // Clear()
            // 배열의 모든 요소를 초기화
            // 배열이 숫자 형식이면 0, 논리 형식 기반이면 false, 참조 형식 기반이면 null로 초기화
            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // Copy<T>()
            // 배열의 일부를 다른 배열에 복사
            int[] sliced = new int[3];

            // scores 배열의 0번째부터 3개 요소를 sliced 배열의 0번째~2번째 요소에 차례대로 복사
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}