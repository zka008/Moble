//using System;
//namespace cw
//{
//    class WaterHeater
//    {
//        protected int temperature;
//        public void setTemperature(int temperature)
//        {
//            if (temperature < 10 || temperature > 42)
//            {
//                Console.WriteLine("10~42도 사이의 온도값을 입력하세요.");
//                Console.WriteLine("물의 온도는 15도로 리셋됩니다.");
//                this.temperature = 15;
//                return;
//            }
//            this.temperature = temperature;
//        }
//        public void turnOnWater()
//        {
//            Console.WriteLine($"Turn on water : {temperature}");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            WaterHeater heater = new WaterHeater();
//            int n;

//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write("물의 온도를 입력하세요 : ");
//                n = int.Parse(Console.ReadLine());
//                heater.setTemperature(n);
//                heater.turnOnWater();
//            }
//        }
//    }
//}