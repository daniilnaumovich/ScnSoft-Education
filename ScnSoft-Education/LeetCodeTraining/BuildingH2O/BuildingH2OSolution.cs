using System.Text;

namespace LeetCodeTraining.BuildingH2O
{
    //https://leetcode.com/problems/building-h2o/description/
    public static class BuildingH2OSolution
    {
        public static string BuildWaterMolecules(string input)
        {
            StringBuilder molecules = new StringBuilder();
            H2O water = new H2O();
            Action releaseH = () => { molecules.Append("H"); };
            Action releaseO = () => { molecules.Append("O"); };
            Task[] tasks = new Task[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'H':
                        HydrogenGenerator genH = new HydrogenGenerator(water, releaseH);
                        Task h = Task.Factory.StartNew(genH.GenerateElement);
                        tasks[i] = h;
                        break;
                    case 'O':
                        OxygenGenerator genO = new OxygenGenerator(water, releaseO);
                        Task o = Task.Factory.StartNew(genO.GenerateElement);
                        tasks[i] = o;
                        break;
                }
            }

            Task.WaitAll(tasks);

            return molecules.ToString();
        }
    }

    public class H2O
    {
        private SemaphoreSlim hydrogen = new SemaphoreSlim(0, 2);
        private SemaphoreSlim oxygen = new SemaphoreSlim(1, 1);
        private object locker = new object();
        private int hydrogenCounter = 0;

        public H2O() { }

        public void Hydrogen(Action releaseHydrogen)
        {
            hydrogen.Wait();

            lock (locker)
            {
                // releaseHydrogen() outputs "H". Do not change or remove this line.
                releaseHydrogen();
                hydrogenCounter++;
            }

            if (hydrogenCounter == 2)
            {
                oxygen.Release();
                hydrogenCounter = 0;
            }
        }

        public void Oxygen(Action releaseOxygen)
        {
            oxygen.Wait();
            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();
            hydrogen.Release(2);
        }
    }

    public class HydrogenGenerator
    {
        private readonly Random rnd = new Random();
        private readonly H2O water;
        private readonly Action generator;

        public HydrogenGenerator(H2O h2o, Action generateElement)
        {
            water = h2o;
            generator = generateElement;
        }

        public void GenerateElement()
        {
            Task.Delay(rnd.Next(500));
            water.Hydrogen(generator);
        }
    }

    public class OxygenGenerator
    {
        private readonly Random rnd = new Random();
        private readonly H2O water;
        private readonly Action generator;

        public OxygenGenerator(H2O h2o, Action generateElement)
        {
            water = h2o;
            generator = generateElement;
        }

        public void GenerateElement()
        {
            Task.Delay(rnd.Next(500));
            water.Oxygen(generator);
        }
    }
}
