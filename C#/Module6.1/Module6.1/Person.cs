
namespace Module6._1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int UntilRetirement {

            get {

                return 65 - Age;
            }
        }

        public int GetUntilRetirement()
        {
            return 65 - Age;
        }
    }
}
