namespace Practice
{
    //строки 554-565 из файла MainSpace.cs
    internal class Gun
    {
        public Gun(bool isLoaded)
        {
            this.isLoaded = isLoaded;
        }

        private bool isLoaded;
        private void Reload()
        {
            Console.WriteLine("Перезаряжаю...");
            isLoaded = true;
            Console.WriteLine("Готов к стрельбе!");
        }
        public void Shoot()
        {
            if (isLoaded)
            {
                Console.WriteLine("Пыщ-пыщ");
            }
            else
            {
                Console.WriteLine("Оружие не заряжено.");
                Reload();
                Console.WriteLine("Пыщ-пыщ");
            }
        }
    }
}
