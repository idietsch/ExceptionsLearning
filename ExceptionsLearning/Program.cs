using System;

namespace ExceptionsLearning {
    class Program {
        static void Main(string[] args) {
            var a = 1;
            var b = 2;
            try {

                string x = "ABC";
                x = null;
                var len = x.Length;
            } catch (NullReferenceException ex) {
                var bce = new BootcampException("Bootcamp Exception", ex);
                throw bce;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            try {
            var c = a / (b - b);

            } catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }

            //var d = 1 / 0; //divide by 0 causes error
        }
    }
}
