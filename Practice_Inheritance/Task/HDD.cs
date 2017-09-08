using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class HDD : Storage
    {
        public int Speed { get; set; }
        public int CountPartition { get; set; }
        public int MemoryPartition { get; set; }
        public int FreeMemory { get; set; }

        public HDD(string name, string model, int speed, int memoryPartition, int countPartition)
        {
            Name = name;
            Model = model;
            Speed = speed;
            MemoryPartition = memoryPartition;
            CountPartition = countPartition;
            Memory = MemoryPartition * CountPartition;
            Remain = 0;
        }

        public override void CopyData(File[] files)
        {
            int fileSize = 0;
            for (int i = 0; i < files.Length; ++i)
            {
                fileSize += files[i].FileSize;
            }
            Remain = fileSize;
        }
        public override string GetFullInfo()
        {
            return String.Format("Скорость - {0}, Количество разделов - {1}, " +
                "Объем памяти раздела - {2}, Память - {3}", 
                Speed, CountPartition, MemoryPartition, Memory);
        }
        public override int GetMemory()
        {
            return Memory;
        }
        public override int GetFreeMemory()
        {
            FreeMemory = Memory - Remain;
            return FreeMemory;
        }
    }
}
