namespace Exercise_2
{
    public class Bus : Vehicle, ITaxable
    {
        protected int numberOfSeats;

        public Bus(int numberOfSeats, int regNumber, decimal value):
            base(regNumber, 80, value){
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats{
            get{
                return numberOfSeats;
            }
        }

        public decimal TaxValue()
        {

            return 500;
        }
    }
}