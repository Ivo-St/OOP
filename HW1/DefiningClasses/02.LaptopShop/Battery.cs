namespace LaptopShop
{
    public class Battery
    {
        private string type;
        private int capacity;
        private int cells;

        public string Type
        {
            set
            {
                Validator.checkString(value, "Battery type");
                this.type = value;
            }

            get
            {
                return this.type;
            }
        }

        public int Capacity
        {
            set
            {
                Validator.checkInt(value, "Battery capacity");
                this.capacity = value;
            }

            get
            {
                return this.capacity;
            }
        }

        public int Cells
        {
            set
            {
                Validator.checkInt(value, "Battery Cells");
                this.cells = value;
            }

            get
            {
                return this.cells;
            }
        }

        public Battery(string type, int cells, int capacity)
        {
            Type = type;
            Cells = cells;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return Type + ", " + Cells + "-cells, " + Capacity + " mAh";
        }
    }
}
