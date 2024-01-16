//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;

//namespace CodeWork.D15
//{
//    internal class CarPicture
//    {
//        //필드(자동차가 가지고 있는 고유의 정보) - 데이터 표현
//        private int carHeight;  //private 클래스 외부에서 사용 불가
//        private int carWidth;
//        private string carName;  //public 어디서든 사용 가능
//        private Color carColor;

//        //생성자
//        public CarPicture() {   //생성자는 항상 public, 필드값 초기화
//            carName = "casper";
//            carHeight = 140;
//            carWidth = 200;
//            carColor = Color.DarkKhaki;
//        }
//        public CarPicture(string carName, int carWidth, int carHeight, Color carColor)
//        {
//            this.carName = carName;
//            this.carHeight = carHeight;
//            this.carWidth = carWidth;
//            this.carColor = carColor;
//        }

//        //getter setter 속성, private로 되어있는 멤버 변수에 접근 가능
//        public int Height
//        {
//            get { return carHeight; }
//            set { if (value > 0) carHeight = value; }
//        }
//        public int Width
//        {
//            get { return carWidth; }
//            set { if (value > 0) carWidth = value; }
//        }
//        public string Name
//        {
//            get { return carName; }
//            set { carName = value; }
//        }
//        public Color Color
//        {
//            get { return carColor; }
//            set { carColor = value; }
//        }

//        //계산하는 속성
//        public int Area
//        {
//            get { return carWidth * carHeight; }
//        }

//        //메소드
//        public void MakeCar()
//        {
//            if (ProcessStarted != null)
//                ProcessStarted(this, EventArgs.Empty);
//            Step1();
//            Step2();
//            Step3();
//            if (ProcessEnded != null)
//                ProcessEnded(this, EventArgs.Empty);
//        }
//        public void Step1()
//        {
//            Console.WriteLine("Step #1");
//        }
//        public void Step2()
//        {
//            Console.WriteLine("Step #2");
//        }
//        public void Step3()
//        {
//            Console.WriteLine("Step #3");
//        }
//        //이벤트 선언
//        public event EventHandler ProcessStarted;
//        public event EventHandler ProcessEnded;
//    }
//}
