    namespace Practice
{
    internal class MyClass1
    {
        public MyClass1()
        {
            counter++;
        }
        private static int counter;
        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

    }
}
