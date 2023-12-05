using System.Text;

namespace LeetCodeTraining.PrintInOrder
{
    //https://leetcode.com/problems/print-in-order/description/
    public static class PrintInOrderSolution
    {
        public static string PrintInOrder(int[] input)
        {
            StringBuilder output = new StringBuilder();
            Foo writer = new Foo();
            Action printFirst = () => { output.Append("first"); };
            Action printSecond = () => { output.Append("second"); };
            Action printThird = () => { output.Append("third"); };
            Task[] tasks = new Task[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 1:
                        SequenceWriter first = new SequenceWriter(writer, 1, printFirst);
                        Task f = Task.Factory.StartNew(first.Print);
                        tasks[i] = f;
                        break;
                    case 2:
                        SequenceWriter second = new SequenceWriter(writer, 2, printSecond);
                        Task s = Task.Factory.StartNew(second.Print);
                        tasks[i] = s;
                        break;
                    case 3:
                        SequenceWriter third = new SequenceWriter(writer, 3, printThird);
                        Task t = Task.Factory.StartNew(third.Print);
                        tasks[i] = t;
                        break;
                }
            }

            Task.WaitAll(tasks);

            return output.ToString();
        }
    }

    public class Foo
    {
        private ManualResetEvent firstCompleted = new ManualResetEvent(false);
        private ManualResetEvent secondCompleted = new ManualResetEvent(false);

        public Foo() { }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            firstCompleted.Set();
        }

        public void Second(Action printSecond)
        {
            firstCompleted.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            secondCompleted.Set();
        }

        public void Third(Action printThird)
        {
            secondCompleted.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }

    public class SequenceWriter
    {
        private Random rnd = new Random();
        private readonly Foo foo;
        private readonly int number;
        private readonly Action print;

        public SequenceWriter(Foo foo, int number, Action print)
        {
            this.foo = foo;
            this.number = number;
            this.print = print;
        }

        public void Print()
        {
            Task.Delay(rnd.Next(1000));

            switch (number)
            {
                case 1:
                    foo.First(print);
                    break;
                case 2:
                    foo.Second(print);
                    break;
                case 3:
                    foo.Third(print);
                    break;
            }
        }
    }
}
