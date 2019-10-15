using System;
using System.Collection.Generics;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio aRadio = new Radio();
            Radio anotherRadio= new Radio();
            AllinOne anAllinOne = new AllinOne();
            List<IRadio> iradiolist= new List<IRadio>(){
                aRadio,anotherRadio,anotherRadio,anAllinOne
            };
            TestRadios(iradiolist);

        }
        static void TestRadios(List<IRadio> radios){
            foreach (radion in radios)
            {
                radio.TurnRadioOn();
                radio.TurnRadioOff();
            }

        }
    }
}
