using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Flash : Storage
    {
        public int SpeedUSB3 { get; set; }
        public int FreeMemory { get; set; }

        public Flash(string name, string model, int memory, int speedUSB3)
        {
            Name = name;
            Model = model;
            SpeedUSB3 = speedUSB3;
            Memory = memory;
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
        public override string GetFullInfo()
        {
            return String.Format("Скорость USB3.0 - {0}, Объем памяти - {1}", SpeedUSB3, Memory);
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
    }
}
