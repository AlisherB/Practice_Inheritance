namespace Task
{
    public abstract class Storage
    {
        private string name;
        private string model;
        public int Remain { get; set; }
        public int Memory { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public abstract void CopyData(File[] files);
        public abstract int GetMemory();
        public abstract int GetFreeMemory();
        public abstract string GetFullInfo();
    }
}