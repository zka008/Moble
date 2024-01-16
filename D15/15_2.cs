//using CodeWork.D15;
//using System;
//using System.Drawing;
//namespace CodeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CarPicture carPicture1 = new CarPicture();
//            Console.WriteLine("속성을 지정해 초기화되어 있는 첫번째 생성자에서의 출력");
//            Console.WriteLine("{0} : {1}", "자동차의 길이", carPicture1.Width);
//            Console.WriteLine("자동차의 높이 : " + carPicture1.Height);
//            Console.WriteLine("자동차의 이름 : " + carPicture1.Name);
//            Console.WriteLine("자동차의 색깔 : " + carPicture1.Color + "\n");

//            CarPicture carPicture2 = new CarPicture();
//            carPicture2.Width = 300;
//            carPicture2.Height = 100;
//            carPicture2.Name = "abc";
//            carPicture2.Color = Color.White;
//            Console.WriteLine("set을 통한 속성에 값 입력");
//            Console.WriteLine("자동차의 길이 : " + carPicture2.Width);
//            Console.WriteLine("자동차의 높이 : " + carPicture2.Height);
//            Console.WriteLine("자동차의 이름 : " + carPicture2.Name);
//            Console.WriteLine("자동차의 색깔 : " + carPicture2.Color + "\n");

//            CarPicture carPicture3 = new CarPicture("Santape", 210, 160, Color.Brown);
//            Console.WriteLine("4개의 파라미터를 갖는 생성자의 필드 출력");
//            Console.WriteLine("자동차의 길이 : " + carPicture3.Width);
//            Console.WriteLine("자동차의 높이 : " + carPicture3.Height);
//            Console.WriteLine("자동차의 이름 : " + carPicture3.Name);
//            Console.WriteLine("자동차의 색깔 : " + carPicture3.Color);

//            Console.WriteLine("\n계산하는 속성 추가");
//            Console.WriteLine("자동차의 면적 : " + carPicture3.Area);

//            Console.WriteLine("\n메소드 호출");
//            carPicture3.MakeCar();

//            Console.WriteLine("\n이벤트 호출");
//            //+= 연사자를 사용하여 이벤트 자동 생성
//            carPicture3.ProcessStarted += CarPicture3_ProcessStarted;
//            carPicture3.ProcessEnded += CarPicture3_ProcessEnded;
//            carPicture3.MakeCar();
//        }
//        private static void CarPicture3_ProcessStarted(object? sender, EventArgs e)
//        {
//            Console.WriteLine("Process Started");
//        }
//        private static void CarPicture3_ProcessEnded(object? sender, EventArgs e)
//        {
//            Console.WriteLine("Process Ended");
//        }
//    }
//}