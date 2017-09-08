using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Calculation
    {
        public int AllMemory { get; set; }
        public void CalcAllMemory (Storage[] storages)
        {
            for (int i = 0; i < storages.Length; ++i)
            {
                AllMemory += storages[i].GetMemory();
            }
        }
        public int CopyTime(Storage storage, int speed)
        {
            int time = storage.Remain / speed;
            return time;
        }
        public int AmountStorage(File[] files, int memory)
        {
            int fileSize = 0;
            for (int i = 0; i < files.Length; ++i)
            {
                fileSize += files[i].FileSize;
            }
            int amountStorage = (fileSize / memory) + 1;
            return amountStorage;
        }
    }
}
