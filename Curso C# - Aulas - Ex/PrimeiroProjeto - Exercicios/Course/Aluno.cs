//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Course
//{
//    internal class Aluno
//    {
//        public string? Nome;
//        public double Nota1, Nota2, Nota3;

//        public double NotaFinal()
//        {
//            return Nota1 + Nota2 + Nota3;
//        }

//        public bool AprovaAluno()
//        {
//            if(NotaFinal() >= 60.0)
//            {
//                return true;
//            } 
//            else
//            {
//                return false;
//            }
//        }

//        public double NotaRestante()
//        {
//            if (AprovaAluno())
//            {
//                return 0.0;
//            }
//            else
//            {
//                return 60.0 - NotaFinal();
//            }
//        }
//    }
//}
