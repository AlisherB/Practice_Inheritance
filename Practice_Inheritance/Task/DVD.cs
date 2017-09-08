using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class DVD : Storage
    {
        public int SpeedReadWrite { get; set; }
        public int OneSided { get; set; }
        public int DoubleSided { get; set; }
        public int FreeMemory { get; set; }

        public DVD(string name, string model, int side, int speedReadWrite)
        {
            Name = name;
            Model = model;
            SpeedReadWrite = speedReadWrite;
            OneSided = side;
            DoubleSided = side;
            if (OneSided == side)
            {
                Memory = 4700;
            }
            else if (DoubleSided == side)
            {
                Memory = 9000;
            }
        }

        public override void CopyData(File[] files)
        {
            int fileSize = 0;
            for (int i = 0; i < files.Length; i++)
            {
                fileSize += files[i].FileSize;
            }
            Remain = fileSize;
        }

        public override int GetFreeMemory()
        {
            FreeMemory = Memory - Remain;
            return FreeMemory;
        }

        public override string GetFullInfo()
        {
            return String.Format("Название - {0}, Модель - {1}, Объем памяти - {2}, Скорость чтения//записи - {3}", Name, Model, Memory, SpeedReadWrite);
        }

        public override int GetMemory()
        {
            return Memory;
        }
    }
}
