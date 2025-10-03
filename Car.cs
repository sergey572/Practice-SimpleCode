namespace Practice
{
    //строки 550-560 из файла MainSpace.cs
    internal class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine($"Стоим на месте. Скорость {speed} км/ч.");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем со скоростью: {speed} км/ч.");
            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем задним ходом со скоростью {Math.Abs(speed)} км/ч.");
            }
        }
        public void DriveForward()
        {
            speed = new Random().Next(20, 60);
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = new Random().Next(-20, -1);
        }        
    }
}
