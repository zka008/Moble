//using System;
//namespace CodeWork
//{
//    class FolderPhone
//    {
//        public virtual void Network() { }
//    }
//    class ThreeGPhone : FolderPhone
//    {
//        public sealed override void Network() { }
//    }
//    class SmartPhone : ThreeGPhone
//    {
//        public override void Network() { } //ThreeGPhone의 Network는 봉인됨, 오류 발생
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            FolderPhone phone = new FolderPhone();
//            ThreeGPhone threeGPhone = new ThreeGPhone();
//            phone.Network();
//            threeGPhone.Network();
//        }
//    }
//}