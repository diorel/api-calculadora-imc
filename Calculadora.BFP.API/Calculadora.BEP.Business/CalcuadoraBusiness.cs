using Calculadora.BFP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.BEP.Business
{
    public class CalcuadoraBusiness
    {




        public double ResulatadoHombreBusiness(DatosHombre dt)
        {
            double BFP = 0;

            double num = 0;
            try
            {
                double waist = Convert.ToDouble(dt.Waist); // cintura
                double neck = Convert.ToDouble(dt.Neck); // cuello
                double height = Convert.ToDouble(dt.Height); // altura

                int const1 = 495;
                double const2 = 1.0324;
                double const3 = 0.19077;
                double const4 = 0.15456;

                double Resulatodo1 = 0;
                double Resulatodo2 = 0;
                double Resulatodo3 = 0;
                double Resulatodo4 = 0;

                Resulatodo1 = const2 - const3 * Math.Log10(waist - neck);
                Resulatodo2 = const4 * Math.Log10(height);
                Resulatodo3 = Resulatodo1 + Resulatodo2;
                Resulatodo4 = const1 / Resulatodo3;
                BFP = Resulatodo4 - 450;

                num = (Math.Truncate(BFP * 100) / 100);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return num;
        }

        public double ResulatadoMujerBusiness(DatosMujer dt)
        {
            double BFP = 0;
            double num = 0;
            try
            {
                double waist = Convert.ToDouble(dt.Waist); // cintura
                double neck = Convert.ToDouble(dt.Neck); // cuello
                double height = Convert.ToDouble(dt.Height); // altura
                double hip = Convert.ToDouble(dt.Hip); // cadera 

                int const1 = 495;
                double const2 = 1.29579;
                double const3 = 0.35004;
                double const4 = 0.22100;

                double Resulatodo1 = 0;
                double Resulatodo2 = 0;
                double Resulatodo3 = 0;
                double Resulatodo4 = 0;

                Resulatodo1 = const2 - const3 * Math.Log10(waist + hip - neck);
                Resulatodo2 = const4 * Math.Log10(height);
                Resulatodo3 = Resulatodo1 + Resulatodo2;
                Resulatodo4 = const1 / Resulatodo3;
                BFP = Resulatodo4 - 450;

                num = (Math.Truncate(BFP * 100) / 100);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return num;
        }


      
    }
}
